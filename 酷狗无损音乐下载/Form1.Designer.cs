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
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "下载到";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 489);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(358, 21);
            this.textBox2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.LightBlue;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Gainsboro;
            this.skinButton1.GlowColor = System.Drawing.Color.LightBlue;
            this.skinButton1.Location = new System.Drawing.Point(418, 50);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "搜素";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.Location = new System.Drawing.Point(219, 447);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(88, 29);
            this.skinButton2.TabIndex = 10;
            this.skinButton2.Text = "下载";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.LightBlue;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.DownBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton3.Location = new System.Drawing.Point(418, 488);
            this.skinButton3.MouseBack = null;
            this.skinButton3.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 11;
            this.skinButton3.Text = "浏览";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(4, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
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
            this.resultListView.Size = new System.Drawing.Size(486, 362);
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
            this.time.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CaptionHeight = 20;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
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
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader bitRate;
        private System.Windows.Forms.ColumnHeader extName;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader size;
    }
}

