using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransBrowser
{
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.SetMainForm(this);
            setting.Show();
        }

        public void LoadUrl(string url)
        {
            try
            {
                this.webView21.Source = new Uri(url);
            }
            catch(Exception e)
            {
                Tools.LogHelper.Error(e);
            } 
        }
        public void SetTans(double trans)
        {
            this.Opacity = trans;
        }
        public void SetDefaultColor(Color color)
        {
            this.webView21.DefaultBackgroundColor = color;
            this.windowBar1.BackColor = color;
        }

        public void SetShowInTaskBar(bool show)
        {
            this.ShowInTaskbar = show;
        }

        public void ShowWindowsBar(bool show)
        {
            this.windowBar1.Visible = show;
        }
    }
}
