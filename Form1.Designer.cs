namespace ColorfulLedKeyboardSet
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip contextmenustrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.CustomRGB_B = new System.Windows.Forms.Button();
            this.GetSource_L = new System.Windows.Forms.LinkLabel();
            this.ColorTestLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button3 = new System.Windows.Forms.Button();
            contextmenustrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            contextmenustrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // contextmenustrip1
            // 
            contextmenustrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            contextmenustrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3});
            contextmenustrip1.Name = "contextmenustrip1";
            contextmenustrip1.Size = new System.Drawing.Size(117, 94);
            contextmenustrip1.Text = "功能";
            contextmenustrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextmenustrip1_Opening);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(116, 30);
            this.ToolStripMenuItem1.Text = "显示";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(116, 30);
            this.ToolStripMenuItem2.Text = "隐藏";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(116, 30);
            this.ToolStripMenuItem3.Text = "关闭";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "RGB循环";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 7;
            this.speedBar.Location = new System.Drawing.Point(224, 13);
            this.speedBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speedBar.Maximum = 7;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(127, 69);
            this.speedBar.TabIndex = 1;
            this.speedBar.Value = 1;
            // 
            // CustomRGB_B
            // 
            this.CustomRGB_B.Location = new System.Drawing.Point(12, 92);
            this.CustomRGB_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomRGB_B.Name = "CustomRGB_B";
            this.CustomRGB_B.Size = new System.Drawing.Size(109, 41);
            this.CustomRGB_B.TabIndex = 2;
            this.CustomRGB_B.Text = "自定义RGB";
            this.CustomRGB_B.UseVisualStyleBackColor = true;
            this.CustomRGB_B.Click += new System.EventHandler(this.CustomRGB_B_Click);
            // 
            // GetSource_L
            // 
            this.GetSource_L.Location = new System.Drawing.Point(0, 0);
            this.GetSource_L.Name = "GetSource_L";
            this.GetSource_L.Size = new System.Drawing.Size(100, 23);
            this.GetSource_L.TabIndex = 7;
            // 
            // ColorTestLabel
            // 
            this.ColorTestLabel.AutoSize = true;
            this.ColorTestLabel.Location = new System.Drawing.Point(357, 24);
            this.ColorTestLabel.Name = "ColorTestLabel";
            this.ColorTestLabel.Size = new System.Drawing.Size(116, 18);
            this.ColorTestLabel.TabIndex = 5;
            this.ColorTestLabel.Text = "您的键盘颜色";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "停止循环";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = contextmenustrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "开机启动";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 150);
            this.ContextMenuStrip = contextmenustrip1;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColorTestLabel);
            this.Controls.Add(this.GetSource_L);
            this.Controls.Add(this.CustomRGB_B);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoghurt";
            this.Load += new System.EventHandler(this.Form1_Load);
            contextmenustrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Button CustomRGB_B;
        private System.Windows.Forms.LinkLabel GetSource_L;
        private System.Windows.Forms.Label ColorTestLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button3;
    }
}

