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
        public bool inited = false;
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
            Setting setting = new Setting(this);
            //setting.SetMainForm(this);
            setting.Show();
        }

        public void LoadUrl(string url)
        {
            try
            {

                if(this.webView21.Source!=null&&url == this.webView21.Source.AbsoluteUri)
                {
                    this.webView21.Reload();
                    return;
                } 
                this.webView21.Source = new Uri(url);
            }
            catch(Exception e)
            {
                Tools.LogHelper.Error(e);
            } 
        }
        public void SetTans(double trans)
        {
            trans = Math.Round(trans / 100.0, 2);
            this.Opacity = trans;
        }
        public void SetDefaultColor(Color color)
        {
            //this.webView21.DefaultBackgroundColor = color;
            this.pageHeader1.BackColor = color;
        }

        public void SetShowInTaskBar(bool show)
        {
            this.ShowInTaskbar = show;
        }
        public void SetSize(Size size)
        {
            this.Size = size;
        }
        public void ShowWindowsBar(bool noTitle)
        {
            this.pageHeader1.Visible = !noTitle;
        }
        public void SetPosition(Point point)
        {
             
            this.Location = point;
        } 
        public void SetMobileMold(bool mobileMold)
        {
            
        }
        public void SetUA(string UA)
        {
            if (!string.IsNullOrEmpty(UA)) {
                var settings = webView21.CoreWebView2.Settings;
                settings.UserAgent = UA;
            }
           
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
        }
        public void Init()
        {
            ShowWindowsBar(Properties.Settings.Default.NoTitle);
            SetShowInTaskBar(Properties.Settings.Default.ShowInTaskbar);
            SetPosition(Properties.Settings.Default.FormPosition);
            
            SetTans(Properties.Settings.Default.FormOpacity);
            SetDefaultColor(Properties.Settings.Default.ThemeBackColor);
            SetSize(Properties.Settings.Default.FormSize);

            //SetUA(Properties.Settings.Default.DefaultUA);
            LoadUrl(Properties.Settings.Default.DefaultUrl);
            inited = true;
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal&&inited)
            {
                Properties.Settings.Default.FormPosition =this.Location;
                Properties.Settings.Default.Save();
            }
          
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            var size= ((System.Windows.Forms.Control)sender).Size;
            Properties.Settings.Default.FormSize = size;
            Properties.Settings.Default.Save();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出程序
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
            this.Close();
        }
    }
}
