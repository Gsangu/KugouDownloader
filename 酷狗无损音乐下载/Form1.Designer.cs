namespace 酷狗无损音乐下载
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchBtn = new CCWin.SkinControl.SkinButton();
            this.downBtn = new CCWin.SkinControl.SkinButton();
            this.pathBtn = new CCWin.SkinControl.SkinButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastPageBtn = new CCWin.SkinControl.SkinButton();
            this.nextPageBtn = new CCWin.SkinControl.SkinButton();
            this.pageNum = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "下载到";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 515);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(358, 21);
            this.textBox2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.searchBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searchBtn.DownBack = null;
            this.searchBtn.DownBaseColor = System.Drawing.Color.Gainsboro;
            this.searchBtn.GlowColor = System.Drawing.Color.LightBlue;
            this.searchBtn.Location = new System.Drawing.Point(428, 48);
            this.searchBtn.MouseBack = null;
            this.searchBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NormlBack = null;
            this.searchBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.BackColor = System.Drawing.Color.Transparent;
            this.downBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.downBtn.DownBack = null;
            this.downBtn.DownBaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.Location = new System.Drawing.Point(218, 480);
            this.downBtn.MouseBack = null;
            this.downBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.Name = "downBtn";
            this.downBtn.NormlBack = null;
            this.downBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.downBtn.Size = new System.Drawing.Size(88, 29);
            this.downBtn.TabIndex = 10;
            this.downBtn.Text = "下载";
            this.downBtn.UseVisualStyleBackColor = false;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // pathBtn
            // 
            this.pathBtn.BackColor = System.Drawing.Color.Transparent;
            this.pathBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pathBtn.DownBack = null;
            this.pathBtn.DownBaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.Location = new System.Drawing.Point(418, 513);
            this.pathBtn.MouseBack = null;
            this.pathBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.NormlBack = null;
            this.pathBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pathBtn.Size = new System.Drawing.Size(75, 25);
            this.pathBtn.TabIndex = 11;
            this.pathBtn.Text = "浏览";
            this.pathBtn.UseVisualStyleBackColor = false;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(4, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "准备就绪";
            // 
            // resultListView
            // 
            this.resultListView.CheckBoxes = true;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.bitRate,
            this.extName,
            this.size,
            this.time});
            this.resultListView.FullRowSelect = true;
            this.resultListView.Location = new System.Drawing.Point(7, 79);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(496, 362);
            this.resultListView.TabIndex = 14;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "歌名";
            this.name.Width = 274;
            // 
            // bitRate
            // 
            this.bitRate.Text = "比特率";
            // 
            // extName
            // 
            this.extName.Text = "格式";
            this.extName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.extName.Width = 40;
            // 
            // size
            // 
            this.size.Text = "大小";
            // 
            // time
            // 
            this.time.Text = "时长";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.lastPageBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.lastPageBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.lastPageBtn.DownBack = null;
            this.lastPageBtn.DownBaseColor = System.Drawing.Color.Gainsboro;
            this.lastPageBtn.Enabled = false;
            this.lastPageBtn.GlowColor = System.Drawing.Color.LightBlue;
            this.lastPageBtn.Location = new System.Drawing.Point(376, 447);
            this.lastPageBtn.MouseBack = null;
            this.lastPageBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.NormlBack = null;
            this.lastPageBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.lastPageBtn.Size = new System.Drawing.Size(60, 25);
            this.lastPageBtn.TabIndex = 15;
            this.lastPageBtn.Text = "上一页";
            this.lastPageBtn.UseVisualStyleBackColor = false;
            this.lastPageBtn.Click += new System.EventHandler(this.lastPageBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.nextPageBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.nextPageBtn.DownBack = null;
            this.nextPageBtn.DownBaseColor = System.Drawing.Color.Gainsboro;
            this.nextPageBtn.Enabled = false;
            this.nextPageBtn.GlowColor = System.Drawing.Color.LightBlue;
            this.nextPageBtn.Location = new System.Drawing.Point(442, 447);
            this.nextPageBtn.MouseBack = null;
            this.nextPageBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.NormlBack = null;
            this.nextPageBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.nextPageBtn.Size = new System.Drawing.Size(60, 25);
            this.nextPageBtn.TabIndex = 16;
            this.nextPageBtn.Text = "下一页";
            this.nextPageBtn.UseVisualStyleBackColor = false;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // pageNum
            // 
            this.pageNum.AutoSize = true;
            this.pageNum.Location = new System.Drawing.Point(329, 453);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(0, 12);
            this.pageNum.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CaptionHeight = 20;
            this.ClientSize = new System.Drawing.Size(510, 570);
            this.Controls.Add(this.pageNum);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 570);
            this.MinimumSize = new System.Drawing.Size(510, 570);
            this.Name = "Form1";
            this.Radius = 10;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酷狗无损音乐下载工具";
            this.TitleCenter = true;
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton searchBtn;
        private CCWin.SkinControl.SkinButton downBtn;
        private CCWin.SkinControl.SkinButton pathBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader bitRate;
        private System.Windows.Forms.ColumnHeader extName;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader size;
        private CCWin.SkinControl.SkinButton lastPageBtn;
        private CCWin.SkinControl.SkinButton nextPageBtn;
        private System.Windows.Forms.Label pageNum;
    }
}

