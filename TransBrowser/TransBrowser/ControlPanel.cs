using AntdUI;
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
        public ControlPanel()
        {
            InitializeComponent();
        }

        public void setMainForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
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
            folderBrowser.Filters.Add(new CommonFileDialogFilter("JavaScript文件", "*.js"));
            if (folderBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                 
                var filePath = folderBrowser.FileName; 
                try
                {
                    // 异步读取文件内容
                    string content =  File.ReadAllText(filePath);
                    mainForm?.RunJs(content);
                    
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
    }
}
