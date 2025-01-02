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
        public Setting()
        {
            InitializeComponent();
        }
        public void SetMainForm(MainForm MainForm) {
            this.mainForm = MainForm;
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            this.select1.Items=new AntdUI.BaseCollection() {"中文","English" };
        }

        private void select1_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            var lan= ((AntdUI.Select)sender).SelectedValue.ToString();
            //Tools.LanguageHelper.SetLang(lan, this, typeof(Setting));
        }

        private void slider1_ValueChanged(object sender, IntEventArgs e)
        {
            mainForm.SetTans( Math.Round(slider1.Value / 100.0, 2));
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.LoadUrl(this.input1.Text);
        }

        private void switch1_CheckedChanged(object sender, BoolEventArgs e)
        {
            bool showbar= !e.Value;
            mainForm.ShowWindowsBar(showbar);
        }

        private void switch2_CheckedChanged(object sender, BoolEventArgs e)
        {
            bool check = e.Value;
            mainForm.SetShowInTaskBar(check);
        }

        private void colorPicker1_ValueChanged(object sender, ColorEventArgs e)
        {
            var color = e.Value;
            mainForm.SetDefaultColor(color);
        }
    }
}
