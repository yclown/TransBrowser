using AntdUI;
using Microsoft.Web.WebView2.Core;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransBrowser
{
    public partial class ControlPanel : Window
    {

        private MainForm mainForm;
        private Tools.Ini myIni;
        public ControlPanel()
        {
            InitializeComponent();
            myIni= new Tools.Ini(".ini");
            this.textBox1.Text=myIni.GetValue("Runjs");
        }

        public void setMainForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            mainForm.GetWebView2().NavigationCompleted += AutoScript;
            mainForm.GetWebView2().CoreWebView2.FrameNavigationCompleted += AutoScript;
        }

        private void AutoScript(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {

            if (!string.IsNullOrEmpty(this.textBox1.Text)&&this.checkBox1.Checked)
            {
                mainForm?.RunJs(this.textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm?.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm?.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowser = new CommonOpenFileDialog();
            folderBrowser.Title = "请选择要注入的js文件";
            // 设置文件过滤器 js 或者 txt 
            folderBrowser.Filters.Add(new CommonFileDialogFilter("JS内容", "*.js,*.txt"));
            if (folderBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                 
                var filePath = folderBrowser.FileName; 
                try
                {
                    // 异步读取文件内容
                    string content =  File.ReadAllText(filePath);
                    this.textBox1.Text = content;
                    myIni.WriteValue("Runjs", content);
                    myIni.Save();
                    //mainForm?.RunJs(content);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string content = textBox1.Text;
                if (string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("请输入要注入的js代码");
                    return;
                } 
                mainForm?.RunJs(content);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //mainForm.GetWebView2().NavigationCompleted-= AutoScript;
            this.Hide();
            e.Cancel = true;
        }

        public string GetJs()
        {
            return this.textBox1.Text;
        }
        
    }
}
