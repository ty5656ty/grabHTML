using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grabHTML
{
    public partial class grapHTML : Form
    {
        public grapHTML()
        {
            InitializeComponent();
            type.Items.Add("buddy");
            type.Items.Add("group");
            type.SelectedIndex = 0;
        }

        Uri uri;
        HtmlElement script;
        ProcessStartInfo qqsend;
        int qqbotid;
        bool qqbotrun;
        string js;
        object[] index = new object[1];
        object[] id = new object[1];
        string cmd;

        private void grabHTML_Load(object sender, EventArgs e)
        {
            uri = new Uri(Properties.Settings.Default.html);
            js = File.ReadAllText("readInfo.js");
            index[0] = int.MaxValue;
            qqsend = new ProcessStartInfo();
            htmlpath.Text = Properties.Settings.Default.html;
            qqbotpath.Text = Properties.Settings.Default.qqbot;
            type.Text = Properties.Settings.Default.type;
            name.Text = Properties.Settings.Default.name;
            qqbotrun = false;
            start.Enabled = false;
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            script = webBrowser.Document.CreateElement("script");
            script.SetAttribute("type", "text/javascript");
            script.SetAttribute("text", @js);
            webBrowser.Document.Body.AppendChild(script);
            webBrowser.Document.InvokeScript("getinfo");
            string strinfo1 = webBrowser.Document.InvokeScript("getcurrent") as string;
            string strinfo2 = webBrowser.Document.InvokeScript("getgoal") as string;
            strinfo2 = strinfo2.Substring(6);
            string strinfo3 = webBrowser.Document.InvokeScript("getpercent") as string;
            string strinfo4 = webBrowser.Document.InvokeScript("getremain") as string ;
            object max = webBrowser.Document.InvokeScript("getcomment", index);
            string idstr = webBrowser.Document.InvokeScript("getlistid") as string;
            JArray idarray = JArray.Parse(idstr);
            JToken[] iddata = idarray.ToArray();
            string comment = "";
            for (int i = 0; i < iddata.Length; i++)
            {
                id[0] = int.Parse(iddata[i].ToString());
                string idinfo = webBrowser.Document.InvokeScript("getidinfo", id) as string;
                comment += idinfo + Environment.NewLine;
            }

            if (comment != "")
            {
                string str = comment + "【孟美岐集资播报】" + Environment.NewLine + "当前：￥" + strinfo1 + " / ￥" + strinfo2 + " 剩余：" + strinfo4 + " 完成：" + strinfo3;
                printfmsg.Text = str + Environment.NewLine;
                qqsend.Arguments = cmd + str;
                Process.Start(qqsend);
            }
            index[0] = max;
            webBrowser.Navigate(uri);
            timer1.Enabled = true;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                string name = fb.SelectedPath;
                if (File.Exists(name + "\\qq.exe") && File.Exists(name + "\\qqbot.exe"))
                {
                    qqbotpath.Text = fb.SelectedPath;
                    return;
                }
                else
                {
                    MessageBox.Show("不是正确的qqbot路径");
                    return;
                }

            }
        }
        
        private void open_Click(object sender, EventArgs e)
        {

        }

        private void runqq_Click(object sender, EventArgs e)
        {
            if (!File.Exists(qqbotpath.Text.Trim() + "\\qq.exe") || !File.Exists(qqbotpath.Text.Trim() + "\\qqbot.exe"))
            {
                MessageBox.Show("不是正确的qqbot路径");
                return;
            }
            qqsend.FileName = qqbotpath.Text.Trim() + "\\qq.exe";
            qqsend.WindowStyle = ProcessWindowStyle.Hidden;
            qqbot.StartInfo.FileName = qqbotpath.Text.Trim() + "\\qqbot.exe";
            qqbot.StartInfo.UseShellExecute = false;
            qqbot.StartInfo.CreateNoWindow = true;
            qqbot.StartInfo.RedirectStandardOutput = true;
            qqbot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            qqbot.Start();
            qqbot.BeginOutputReadLine();
            qqbotrun = true;
            qqbotid = qqbot.Id;
            runqq.Enabled = false;
            start.Enabled = true;
        }

        private void lookup_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!File.Exists(qqbotpath.Text.Trim() + "\\qq.exe") || !File.Exists(qqbotpath.Text.Trim() + "\\qqbot.exe"))
            {
                MessageBox.Show("不是正确的qqbot路径");
                return;
            }
            if (htmlpath.Text.IndexOf("https://zhongchou.modian.com/item/") != 0)
            {
                MessageBox.Show("请输入正确的摩点项目网址");
                return;
            }
            if (name.Text.Length == 0)
            {
                MessageBox.Show("请输入接收者名称");
                return;
            }
            Properties.Settings.Default.html= htmlpath.Text.Trim();
            Properties.Settings.Default.qqbot = qqbotpath.Text.Trim();
            Properties.Settings.Default.name = name.Text.Trim();
            Properties.Settings.Default.type = type.Text.Trim();
            Properties.Settings.Default.Save();
            type.Text = Properties.Settings.Default.type;
            name.Text = Properties.Settings.Default.name;
            cmd = "send " + type.Text.Trim() + " " + name.Text.Trim() + " ";
            type.Enabled = false;
            name.ReadOnly = true;
            webBrowser.Navigate(uri);
            timer1.Enabled = true;
        }

        private void qqbot_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            printout.AppendText(e.Data + Environment.NewLine);
        }

        private void qqbot_Exited(object sender, EventArgs e)
        {
            qqbot.CancelOutputRead();
            qqbotrun = false;
            runqq.Enabled = true;
        }

        private void modianInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qqbotrun)
            {
                qqsend.Arguments = "stop";
                Process.Start(qqsend);
            }
        }
    }
}
