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
    public partial class Setting : Window
    {
        private MainForm mainForm;
        public Setting(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            Init();
        }
        public Setting()
        {
            InitializeComponent();
            //Init();
        }
       
        private void Setting_Load(object sender, EventArgs e)
        {
            //this.select1.Items=new AntdUI.BaseCollection() {"中文","English" };
            
        }
        public void Init() {
            this.slider1.Value = (int)Properties.Settings.Default.FormOpacity;
            this.input1.Text = Properties.Settings.Default.DefaultUrl;
            this.switch1.Checked = Properties.Settings.Default.NoTitle;
            this.switch2.Checked = Properties.Settings.Default.ShowInTaskbar;
            this.colorPicker1.Value = Properties.Settings.Default.ThemeBackColor; //Properties.Settings.Default.ThemeBackColor;  //
             
            //this.select1.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select1_SelectedIndexChanged);
            this.slider1.ValueChanged += new AntdUI.IntEventHandler(this.slider1_ValueChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.switch1.CheckedChanged += new AntdUI.BoolEventHandler(this.switch1_CheckedChanged);
            this.switch2.CheckedChanged += new AntdUI.BoolEventHandler(this.switch2_CheckedChanged);
            this.colorPicker1.ValueChanged += new AntdUI.ColorEventHandler(this.colorPicker1_ValueChanged);

        }
        private void select1_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            var lan= ((AntdUI.Select)sender).SelectedValue.ToString();
            //Tools.LanguageHelper.SetLang(lan, this, typeof(Setting));
        }

        private void slider1_ValueChanged(object sender, IntEventArgs e)
        {
            mainForm.SetTans(slider1.Value);
            Properties.Settings.Default.FormOpacity = slider1.Value;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.LoadUrl(this.input1.Text);
            Properties.Settings.Default.DefaultUrl = this.input1.Text;
            Properties.Settings.Default.Save();
        }

        private void switch1_CheckedChanged(object sender, BoolEventArgs e)
        {
            bool notitle= e.Value;
            mainForm.ShowWindowsBar(notitle);
            Properties.Settings.Default.NoTitle = notitle;
            Properties.Settings.Default.Save();
        }

        private void switch2_CheckedChanged(object sender, BoolEventArgs e)
        {
            bool showintask = e.Value;
            mainForm.SetShowInTaskBar(showintask);
            Properties.Settings.Default.ShowInTaskbar = showintask;
            Properties.Settings.Default.Save();
        }

        private void colorPicker1_ValueChanged(object sender, ColorEventArgs e)
        {
            var color = e.Value;
            mainForm.SetDefaultColor(color);
            Properties.Settings.Default.ThemeBackColor = color;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;
        }

        private void switch3_CheckedChanged(object sender, BoolEventArgs e)
        {
            bool MobileMold = e.Value;
            Properties.Settings.Default.MobileMold = MobileMold;
            Properties.Settings.Default.Save();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var ua= this.ua_input.Text;
            Properties.Settings.Default.DefaultUA = ua;
            Properties.Settings.Default.Save();
            mainForm.SetUA(ua);
        }
    }
}
