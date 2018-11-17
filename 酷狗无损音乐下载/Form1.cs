using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using System.Threading.Tasks;
using System.Threading;

namespace 酷狗无损音乐下载
{
    public partial class Form1 : CCSkinMain
    {
        // 用于将ListView更新的的委托类型
        delegate void UpdateListCallback(List<ListViewItem> listViewItems);

        public Form1()
        {
            InitializeComponent();
            this.Text = "酷狗无损音乐下载工具 V1.1";
        }
        string target = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Download\\";
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = target;
        }

        //浏览
        private void pathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.SelectedPath + "\\";
                target = textBox2.Text;
            }
        }

        int page = 1;

        //搜索
        private void searchBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            GetList(page);
        }

        //上一页
        private void lastPageBtn_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                GetList(page);

                if (page == 1)
                    lastPageBtn.Enabled = false;
            }
        }

        //下一页
        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            page++;
            GetList(page);

            if (page > 1)
            {
                lastPageBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 开始显示进度栏动画
        /// </summary>
        private void StartProcessBar()
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 10;
        }

        /// <summary>
        /// 结束显示进度栏动画
        /// </summary>
        private void StopProcessBar()
        {
            toolStripProgressBar1.Visible = false;
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        }

        /// <summary>
        /// 获取歌曲列表
        /// </summary>
        /// <param name="page"></param>
        private void GetList(int page)
        {
            StartProcessBar();
            pageNum.Text = "第" + page + "页";
            resultListView.Items.Clear();
            toolStripStatusLabel1.Text = "搜索中...";
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            Task getListTask = new Task(() =>
              {
                  WebClient web = new WebClient();
                  string webSite = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword=" + textBox1.Text + "&page=" + page + "&pagesize=100";
                  byte[] buffer = web.DownloadData(webSite);
                  string html = Encoding.UTF8.GetString(buffer);
                  JObject kugou = JObject.Parse(html);
                  List<JToken> all = kugou["data"]["info"].Children().ToList();
                  all.ForEach(x =>
                  {
                      KugouResult kg = JsonConvert.DeserializeObject<KugouResult>(x.ToString());
                      //kg.hash = x["320hash"].ToString();    //320音质的hash值
                      if (kg.sqhash != "")
                      {
                          kg.key = GetMD5(kg.sqhash + "kgcloud");
                          webSite = "http://trackercdn.kugou.com/i/?cmd=4&hash=" + kg.sqhash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1";
                          buffer = web.DownloadData(webSite);
                          html = Encoding.UTF8.GetString(buffer);
                          JObject flac = JObject.Parse(html);
                          if (flac["status"].ToString() == "1")   //成功获取才添加到显示列表和Result中
                          {
                              //SkinListBoxItem sl = new SkinListBoxItem(kg.filename);
                              //resultListView.Items.Add(sl);

                              ListViewItem lvi = new ListViewItem();
                              lvi.Text = kg.filename;
                              lvi.SubItems.Add(flac["bitRate"].ToString());
                              lvi.SubItems.Add(flac["extName"].ToString());
                              lvi.SubItems.Add((double.Parse(flac["fileSize"].ToString()) / (1024 * 1024)).ToString("F2") + "MB");  //将文件大小装换成MB的单位
                              TimeSpan ts = new TimeSpan(0, 0, int.Parse(flac["timeLength"].ToString())); //把秒数换算成分钟数
                              lvi.SubItems.Add(ts.Minutes + ":" + ts.Seconds.ToString("00"));
                              lvi.Tag = flac["url"].ToString().Replace("\\", "");
                              listViewItems.Add(lvi);
                          }
                      }
                  });
                  UpdateUI(listViewItems);
              });
            getListTask.Start();        
        }

        /// <summary>
        /// 用于在获取歌曲列表的Task中更新界面
        /// </summary>
        /// <param name="listViewItems"></param>
        private void UpdateUI(List<ListViewItem> listViewItems)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.resultListView.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.resultListView.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.resultListView.Disposing || this.resultListView.IsDisposed)
                        return;
                }
                UpdateListCallback d = new UpdateListCallback(UpdateUI);
                resultListView.Invoke(d, new object[] { listViewItems });
            }
            else
            {
                resultListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
                resultListView.Items.AddRange(listViewItems.ToArray());
                resultListView.EndUpdate();  //结束数据处理，UI界面一次性绘制
                toolStripStatusLabel1.Text = "搜索完成";
                StopProcessBar();

                if (resultListView.Items.Count > 0)
                {
                    nextPageBtn.Enabled = true;
                }
                else
                {
                    nextPageBtn.Enabled = false;
                }
            }
        }
        
        /// <summary>
        /// 计算MD5获得下载的key值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bf = Encoding.Default.GetBytes(str);
            byte[] mbf = md5.ComputeHash(bf);
            string s = "";
            for (int i = 0; i < mbf.Length; i++)
            {
                s += mbf[i].ToString("x2");
            }
            return s;
        }

        /// <summary>
        /// 下载任务句柄
        /// </summary>
        private List<IntPtr> hTasks = new List<IntPtr>();

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downBtn_Click(object sender, EventArgs e)
        {
            try
            {
                hTasks.Clear();
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;
                foreach (ListViewItem item in resultListView.CheckedItems)
                {
                    timer1.Enabled = true;
                    timer1.Interval = 500;
                    var initSuccess = XL.XL_Init();

                    if (initSuccess)
                    {
                        XL.DownTaskParam p = new XL.DownTaskParam()
                        {
                            IsResume = 0,
                            szTaskUrl = item.Tag.ToString(),    //下载地址
                            szFilename = item.Text +".flac",    //保存文件名
                            szSavePath = target                 //下载目录
                        };
                        IntPtr hTask = XL.XL_CreateTask(p);
                        hTasks.Add(hTask);
                        var startSuccess = XL.XL_StartTask(hTask);
                    }
                    else
                    {
                        MessageBox.Show("XL_Init初始化失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float totalPercent = 0f;    //总进度
            int totalSpeed = 0;         //总速度
            bool isComplete = false;    //是否完成
            foreach (IntPtr hTask in hTasks)
            {
                //获取一个任务的信息保存在info中
                XL.DownTaskInfo info = new XL.DownTaskInfo();
                var qq = XL.XL_QueryTaskInfoEx(hTask, info);
                totalPercent += info.fPercent;
                totalSpeed += info.nSpeed;

                //如果完成了就把完成标记变成true
                if (info.stat == XL.DOWN_TASK_STATUS.TSC_COMPLETE)
                {
                    isComplete = true;
                }
                else
                {
                    isComplete = false;
                }
            }
            totalPercent = totalPercent / hTasks.Count();   //总进度=所有元素的进度加起来/元素数（完成时的进度为1.0）

            toolStripStatusLabel1.Text = "下载进度：" + (int)(totalPercent * 100) + "%"+ string.Format("，速度{0}", (totalSpeed / 1024.0 / 1024.0).ToString("F2") + "MB/s");
            toolStripProgressBar1.Value = (int)(totalPercent * 100);
            if (isComplete)
            {
                toolStripStatusLabel1.Text = "下载完成！";
                timer1.Enabled = false;
                toolStripProgressBar1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
