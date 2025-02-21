
namespace TransBrowser
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label1 = new AntdUI.Label();
            this.slider1 = new AntdUI.Slider();
            this.switch1 = new AntdUI.Switch();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.autohide_sw = new AntdUI.Switch();
            this.label9 = new AntdUI.Label();
            this.switch3 = new AntdUI.Switch();
            this.label2 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.colorPicker1 = new AntdUI.ColorPicker();
            this.label3 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.switch2 = new AntdUI.Switch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new AntdUI.Label();
            this.button2 = new AntdUI.Button();
            this.ua_input = new AntdUI.Input();
            this.label7 = new AntdUI.Label();
            this.button1 = new AntdUI.Button();
            this.input1 = new AntdUI.Input();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new AntdUI.Label();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "不透明度";
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(67, 3);
            this.slider1.MinValue = 1;
            this.slider1.Name = "slider1";
            this.slider1.ShowValue = true;
            this.slider1.Size = new System.Drawing.Size(372, 32);
            this.slider1.TabIndex = 4;
            this.slider1.Text = "slider1";
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(62, 41);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(40, 23);
            this.switch1.TabIndex = 5;
            this.switch1.Text = "switch1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 260);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.autohide_sw);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.slider1);
            this.panel3.Controls.Add(this.switch3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.switch1);
            this.panel3.Controls.Add(this.colorPicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.switch2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 103);
            this.panel3.TabIndex = 20;
            // 
            // autohide_sw
            // 
            this.autohide_sw.Location = new System.Drawing.Point(62, 70);
            this.autohide_sw.Name = "autohide_sw";
            this.autohide_sw.Size = new System.Drawing.Size(40, 23);
            this.autohide_sw.TabIndex = 16;
            this.autohide_sw.Text = "switch4";
            this.autohide_sw.CheckedChanged += new AntdUI.BoolEventHandler(this.switch4_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "失焦隐藏";
            // 
            // switch3
            // 
            this.switch3.Location = new System.Drawing.Point(402, 41);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(40, 23);
            this.switch3.TabIndex = 14;
            this.switch3.Text = "switch3";
            this.switch3.Visible = false;
            this.switch3.CheckedChanged += new AntdUI.BoolEventHandler(this.switch3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "无窗口";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(338, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "手机模式";
            this.label6.Visible = false;
            // 
            // colorPicker1
            // 
            this.colorPicker1.Location = new System.Drawing.Point(290, 41);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(42, 23);
            this.colorPicker1.TabIndex = 9;
            this.colorPicker1.Text = "colorPicker1";
            this.colorPicker1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(108, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "任务栏显示";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(235, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "背景色";
            // 
            // switch2
            // 
            this.switch2.Location = new System.Drawing.Point(189, 41);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(40, 23);
            this.switch2.TabIndex = 7;
            this.switch2.Text = "switch2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ua_input);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Location = new System.Drawing.Point(3, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 81);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "网址";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "切换";
            this.button2.Type = AntdUI.TTypeMini.Primary;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ua_input
            // 
            this.ua_input.Location = new System.Drawing.Point(41, 42);
            this.ua_input.Name = "ua_input";
            this.ua_input.PlaceholderText = "请输入默认页面地址";
            this.ua_input.Size = new System.Drawing.Size(348, 33);
            this.ua_input.TabIndex = 16;
            this.ua_input.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "UA";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "加载";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(41, 3);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "请输入默认页面地址";
            this.input1.Size = new System.Drawing.Size(348, 33);
            this.input1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 54);
            this.panel2.TabIndex = 19;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 29);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(113, 12);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "gitte TransBrowser";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(140, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github TransBrowser";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "开源地址：";
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(480, 23);
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "Setting";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 301);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Slider slider1;
        private AntdUI.Switch switch1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Label label3;
        private AntdUI.Switch switch2;
        private AntdUI.Label label4;
        private AntdUI.ColorPicker colorPicker1;
        private AntdUI.Label label5;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label2;
        private AntdUI.Label label6;
        private AntdUI.Switch switch3;
        private AntdUI.Label label7;
        private AntdUI.Input ua_input;
        private AntdUI.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AntdUI.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel3;
        private AntdUI.Switch autohide_sw;
        private AntdUI.Label label9;
    }
}