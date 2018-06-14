namespace grabHTML
{
    partial class grapHTML
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printfmsg = new System.Windows.Forms.TextBox();
            this.qqbotpath = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.htmlpath = new System.Windows.Forms.TextBox();
            this.runqq = new System.Windows.Forms.Button();
            this.printout = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.lookup = new System.Windows.Forms.Button();
            this.qqbot = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(80, 464);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(116, 78);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printfmsg
            // 
            this.printfmsg.Location = new System.Drawing.Point(12, 128);
            this.printfmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printfmsg.MaxLength = 100;
            this.printfmsg.Multiline = true;
            this.printfmsg.Name = "printfmsg";
            this.printfmsg.ReadOnly = true;
            this.printfmsg.Size = new System.Drawing.Size(359, 499);
            this.printfmsg.TabIndex = 1;
            // 
            // qqbotpath
            // 
            this.qqbotpath.Cursor = System.Windows.Forms.Cursors.Default;
            this.qqbotpath.Location = new System.Drawing.Point(12, 14);
            this.qqbotpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qqbotpath.Name = "qqbotpath";
            this.qqbotpath.ReadOnly = true;
            this.qqbotpath.Size = new System.Drawing.Size(605, 25);
            this.qqbotpath.TabIndex = 3;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.Location = new System.Drawing.Point(163, 92);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(208, 25);
            this.name.TabIndex = 5;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(623, 92);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(119, 28);
            this.start.TabIndex = 6;
            this.start.Text = "开始抓取";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(12, 92);
            this.type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(130, 23);
            this.type.TabIndex = 7;
            // 
            // htmlpath
            // 
            this.htmlpath.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlpath.Location = new System.Drawing.Point(12, 55);
            this.htmlpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlpath.Name = "htmlpath";
            this.htmlpath.ReadOnly = true;
            this.htmlpath.Size = new System.Drawing.Size(605, 25);
            this.htmlpath.TabIndex = 3;
            // 
            // runqq
            // 
            this.runqq.Location = new System.Drawing.Point(377, 92);
            this.runqq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runqq.Name = "runqq";
            this.runqq.Size = new System.Drawing.Size(119, 28);
            this.runqq.TabIndex = 2;
            this.runqq.Text = "启动机器人";
            this.runqq.UseVisualStyleBackColor = true;
            this.runqq.Click += new System.EventHandler(this.runqq_Click);
            // 
            // printout
            // 
            this.printout.Location = new System.Drawing.Point(377, 128);
            this.printout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printout.MaxLength = 100;
            this.printout.Multiline = true;
            this.printout.Name = "printout";
            this.printout.ReadOnly = true;
            this.printout.Size = new System.Drawing.Size(365, 499);
            this.printout.TabIndex = 8;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(623, 14);
            this.browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(119, 28);
            this.browse.TabIndex = 9;
            this.browse.Text = "机器人路径";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(624, 55);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(118, 25);
            this.open.TabIndex = 11;
            this.open.Text = "打开网页";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // lookup
            // 
            this.lookup.Location = new System.Drawing.Point(502, 92);
            this.lookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookup.Name = "lookup";
            this.lookup.Size = new System.Drawing.Size(115, 28);
            this.lookup.TabIndex = 12;
            this.lookup.Text = "查看列表";
            this.lookup.UseVisualStyleBackColor = true;
            this.lookup.Click += new System.EventHandler(this.lookup_Click);
            // 
            // qqbot
            // 
            this.qqbot.EnableRaisingEvents = true;
            this.qqbot.StartInfo.Domain = "";
            this.qqbot.StartInfo.LoadUserProfile = false;
            this.qqbot.StartInfo.Password = null;
            this.qqbot.StartInfo.StandardErrorEncoding = null;
            this.qqbot.StartInfo.StandardOutputEncoding = null;
            this.qqbot.StartInfo.UserName = "";
            this.qqbot.SynchronizingObject = this;
            this.qqbot.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.qqbot_OutputDataReceived);
            this.qqbot.Exited += new System.EventHandler(this.qqbot_Exited);
            // 
            // grapHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 638);
            this.Controls.Add(this.open);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.printout);
            this.Controls.Add(this.type);
            this.Controls.Add(this.start);
            this.Controls.Add(this.name);
            this.Controls.Add(this.htmlpath);
            this.Controls.Add(this.qqbotpath);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.printfmsg);
            this.Controls.Add(this.runqq);
            this.Controls.Add(this.lookup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "grapHTML";
            this.Text = "grabHTML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.modianInfo_FormClosing);
            this.Load += new System.EventHandler(this.grabHTML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox printfmsg;
        private System.Windows.Forms.TextBox qqbotpath;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox htmlpath;
        private System.Windows.Forms.Button runqq;
        private System.Windows.Forms.TextBox printout;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button lookup;
        private System.Diagnostics.Process qqbot;
    }
}

