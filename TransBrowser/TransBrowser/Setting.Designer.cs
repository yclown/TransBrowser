
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
            this.windowBar1 = new AntdUI.WindowBar();
            this.select1 = new AntdUI.Select();
            this.label1 = new AntdUI.Label();
            this.slider1 = new AntdUI.Slider();
            this.switch1 = new AntdUI.Switch();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.switch2 = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.colorPicker1 = new AntdUI.ColorPicker();
            this.label5 = new AntdUI.Label();
            this.input1 = new AntdUI.Input();
            this.button1 = new AntdUI.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBar1
            // 
            this.windowBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar1.Location = new System.Drawing.Point(0, 0);
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(445, 23);
            this.windowBar1.TabIndex = 0;
            this.windowBar1.Text = "Setting";
            // 
            // select1
            // 
            this.select1.List = true;
            this.select1.Location = new System.Drawing.Point(314, 315);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(119, 31);
            this.select1.TabIndex = 1;
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
            this.slider1.Size = new System.Drawing.Size(323, 32);
            this.slider1.TabIndex = 4;
            this.slider1.Text = "slider1";
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(67, 41);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(40, 23);
            this.switch1.TabIndex = 5;
            this.switch1.Text = "switch1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.slider1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.switch1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.switch2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.colorPicker1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.input1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 280);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "无窗口";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(113, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "任务栏显示";
            // 
            // switch2
            // 
            this.switch2.Location = new System.Drawing.Point(194, 41);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(40, 23);
            this.switch2.TabIndex = 7;
            this.switch2.Text = "switch2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(240, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "背景色";
            // 
            // colorPicker1
            // 
            this.colorPicker1.Location = new System.Drawing.Point(295, 41);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.colorPicker1.Size = new System.Drawing.Size(80, 23);
            this.colorPicker1.TabIndex = 9;
            this.colorPicker1.Text = "colorPicker1";
            this.colorPicker1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "网址";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(51, 70);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "请输入默认页面地址";
            this.input1.Size = new System.Drawing.Size(253, 33);
            this.input1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "加载";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 358);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.windowBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Select select1;
        private AntdUI.Label label1;
        private AntdUI.Slider slider1;
        private AntdUI.Switch switch1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Switch switch2;
        private AntdUI.Label label4;
        private AntdUI.ColorPicker colorPicker1;
        private AntdUI.Label label5;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
    }
}