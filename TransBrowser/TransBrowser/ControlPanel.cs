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
    }
}
