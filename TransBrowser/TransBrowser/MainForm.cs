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
using static TransBrowser.Tools.GlobalHotkey;

namespace TransBrowser
{
    public partial class MainForm : Window
    {
        public bool inited = false;
        public MainForm()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(this); 
            setting.StartPosition = FormStartPosition.CenterScreen;
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
            //webView21.EnsureCoreWebView2Async().Wait();
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Deactivate += Form1_Deactivate;
            //webView21.CoreWebView2.NewWindowRequested += NewWindowRequested;
           
            Register();
        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            // Cancel the default behavior of opening a new window
            e.Handled = true; 
            // Navigate to the requested URL in the current WebView2 instance
            //webView21.Source = new Uri(e.Uri);
            LoadUrl(e.Uri);
            Properties.Settings.Default.DefaultUrl = e.Uri;
            Properties.Settings.Default.Save();
        }




        /// <summary>
        /// 失去焦点时自动隐藏窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                return;
            }
            if (Properties.Settings.Default.AutoHide)
            {
                this.Hide();
            }
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
            if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultUrl))
            {
                LoadUrl(Properties.Settings.Default.DefaultUrl);
            }
            else
            {
                LoadUrl("https://gitee.com/yclown/TransBrowser");
            }
            
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

        #region 全局快捷键
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {

            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                //监听快捷键 消息
                case WM_HOTKEY:
                    Deal(this, m.WParam.ToInt32());
                    break;
            }
            base.WndProc(ref m);
        }

        public void Register()
        {
            RegisterHotKey(this.Handle, (int)GlobalEvent.ToggleShow, KeyModifiers.Alt , Keys.D);
            RegisterHotKey(this.Handle, (int)GlobalEvent.ToggleTop, KeyModifiers.Alt , Keys.F);
            RegisterHotKey(this.Handle, (int)GlobalEvent.GoBack, KeyModifiers.Alt|KeyModifiers.Shift , Keys.Z);
            RegisterHotKey(this.Handle, (int)GlobalEvent.ToggleTop, KeyModifiers.Alt | KeyModifiers.Shift, Keys.X);
            RegisterHotKey(this.Handle, (int)GlobalEvent.RunJs, KeyModifiers.Alt | KeyModifiers.Shift, Keys.C);
        }
        public void RunJs(string scritpt)
        {
            webView21.ExecuteScriptAsync(scritpt);
        }
        public enum GlobalEvent
        {
            ToggleShow = 100,
            ToggleTop = 101,
            GoBack = 102,
            GoForward = 103,
            RunJs = 104
        
        }
        private void Deal(MainForm mainForm, int eventId)
        {

            switch (eventId)
            {
                case (int)GlobalEvent.ToggleShow:
                    if (mainForm.Visible)
                    {
                        mainForm.Hide();
                    }
                    else
                    {
                        mainForm.Show();
                        mainForm.Activate();
                    }
                    break;
                case (int)GlobalEvent.ToggleTop:
                    mainForm.TopMost = !mainForm.TopMost;
                    break;
                case (int)GlobalEvent.GoBack:
                    GoBack();
                    break; 
                case (int)GlobalEvent.GoForward:
                    GoForward();
                    break; 
                case (int)GlobalEvent.RunJs:
                    RunJs(control.GetJs());

                    break;
            }



        }
        #endregion


        public void GoBack()
        {
            webView21.GoBack();
        }
        public void GoForward()
        {
            webView21.GoForward();
           
        }
        ControlPanel control = new ControlPanel();
        private void 控制器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            control.setMainForm(this); 
            control.StartPosition = FormStartPosition.CenterScreen;
            control.Show();
        }
        private Point mouseOffset;
        private bool isRightButtonDown;
        private void webView21_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenuStrip.Show(this.PointToScreen(new Point(e.X, e.Y)));
                mouseOffset.X = e.X;
                mouseOffset.Y = e.Y;
                isRightButtonDown = true;
            }
        }

        private void webView21_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightButtonDown)
            {
                Point newLocation = this.Location;
                newLocation.Offset(e.X - mouseOffset.X, e.Y - mouseOffset.Y);
                this.Location = newLocation;
            }
        }

        public Microsoft.Web.WebView2.WinForms.WebView2 GetWebView2()
        {
            return this.webView21;
        }
    }
}
