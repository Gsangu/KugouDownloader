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

namespace 酷狗无损音乐下载
{
    public partial class Form1 : CCSkinMain
    {
        public Form1()
        {
            InitializeComponent();
        }
        string target = Environment.CurrentDirectory + "\\Download\\";
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = target;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.SelectedPath + "\\";
                target = textBox2.Text;
            }
        }
        List<string> Result = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Result.Clear();
            WebClient web = new WebClient();
            string webSite = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword=" + textBox1.Text + "&page=1&pagesize=30";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject kugou = JObject.Parse(html);
            List<JToken> all = kugou["data"]["info"].Children().ToList();
            all.ForEach(x =>
            {
                KugouResult kg = JsonConvert.DeserializeObject<KugouResult>(x.ToString());
                //kg.hash = x["320hash"].ToString();
                if (kg.sqhash != "")
                {
                    SkinListBoxItem sl = new SkinListBoxItem(kg.filename);
                    
                    listBox1.Items.Add(sl);
                    kg.key = GetMD5(kg.sqhash + "kgcloud");
                    webSite = "http://trackercdn.kugou.com/i/?cmd=4&hash=" + kg.sqhash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1";
                    buffer = web.DownloadData(webSite);
                    html = Encoding.UTF8.GetString(buffer);
                    JObject flac = JObject.Parse(html);
                    Result.Add(flac["url"].ToString().Replace("\\",""));
                }
            });

        }
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
        private IntPtr a;
        XL.DownTaskInfo info = new XL.DownTaskInfo();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1.Interval = 500;
                var initSuccess = XL.XL_Init();
                if (initSuccess)
                {
                    XL.DownTaskParam p = new XL.DownTaskParam()
                    {
                        IsResume = 0,
                        szTaskUrl = Result[listBox1.SelectedIndex],//下载地址
                        szFilename = listBox1.SelectedItem.ToString()+".flac",//保存文件名
                        szSavePath = target //下载目录
                    };
                    a = XL.XL_CreateTask(p);
                    var startSuccess = XL.XL_StartTask(a);
                }
                else
                {
                    MessageBox.Show("XL_Init初始化失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var qq = XL.XL_QueryTaskInfoEx(a, info);
            toolStripStatusLabel1.Text = "下载进度："+(int)(info.fPercent * 100)+"%";
            toolStripStatusLabel1.Text += string.Format("，速度{0}", info.nSpeed/1024/1024+"MB/s");
            
            if (info.stat == XL.DOWN_TASK_STATUS.TSC_COMPLETE)
            {
                toolStripStatusLabel1.Text = "下载进度：" + "下载成功！";
                timer1.Enabled = false;
            }
        }
    }
}
