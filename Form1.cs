using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ColorfulLedKeyboardSet
{
    public partial class Form1 : Form
    {

        [DllImport("InsydeDCHU.dll")]
        public static extern int SetDCHU_Data(int command, byte[] buffer, int length);
        String name = AppDomain.CurrentDomain.FriendlyName;
        String path = AppDomain.CurrentDomain.BaseDirectory;
        RegistryKey starts = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void SetColor(int KbPart, Color _color)
        {
            int num = 0;
            switch (KbPart)
            {
                case 1:
                    num = 240;
                    break;
                case 2:
                    num = 241;
                    break;
                case 3:
                    num = 242;
                    break;
                case 7:
                    num = 246;
                    break;
                case 8:
                    num = 243;
                    break;
            }
            uint num2;
            num2 = (uint)((int)_color.B << 16 | (int)_color.R << 8 | (int)_color.G);
            if (_color.R == 0 && _color.G == 255 && _color.B == 127)
            {
                num2 = (uint)(4587520 | (int)_color.R << 8 | (int)_color.G);
            }
                                                  

            byte[] bytes = BitConverter.GetBytes((long)((long)num << 24) + (long)((ulong)num2));
            SetDCHU_Data(103, bytes, 4);
            ColorTestLabel.ForeColor = _color;
        }
        int r = 255;
        int g = 0;
        int b = 0;
        Thread LoopThread;
        private void RGBLoop()
        {
            while (true)
            {
                if (!(g == 255 && r == 0 && b == 255))
                {
                    for (; g < 255; g += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    g = g > 255 ? g = 255 : g;
                    for (; r > 0; r -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    r = r < 0 ? r = 0 : r;
                    for (; b < 255; b += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    b = b > 255 ? b = 255 : b;
                }
                else
                {
                    for (; g > 0; g -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    g = g < 0 ? g = 0 : g;
                    for (; r < 255; r += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    r = r > 255 ? r = 255 : r;
                    for (; b > 0; b -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    b = b < 0 ? b = 0 : b;
                }
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            LoopThread = new Thread(new ThreadStart(() => this.RGBLoop()));
            LoopThread.IsBackground = true;
            LoopThread.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\InsydeDCHU.dll"))
            {
                MessageBox.Show("发生错误:InsydeDCHU.dll缺失\r\n，请检查程序运行文件夹下是否有InsydeDCHU.dll", "发生错误");
                Environment.Exit(0);
            }
            LoopThread = new Thread(new ThreadStart(() => this.RGBLoop()));
            LoopThread.IsBackground = true;
            LoopThread.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            if (starts.GetValue(name)!=null) {
                button3.Text = "取消开机启动";
            }
        }

        private void CustomRGB_B_Click(object sender, EventArgs e)
        {
            if(LoopThread!=null)
            LoopThread.Abort();
            button1.Enabled = true;
            button2.Enabled = false;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SetColor(1, colorDialog1.Color);
                SetColor(2, colorDialog1.Color);
                SetColor(3, colorDialog1.Color);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LoopThread.Abort();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void contextmenustrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //显示窗体
            this.Show();
            //恢复窗体尺寸状态
            this.WindowState = FormWindowState.Normal;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "开机启动")
            {
                starts.SetValue(name, path);
                button3.Text = "取消开机启动";
            }
            else {
                starts.DeleteValue(name);
                button3.Text = "开机启动";
            }
            

        }

    }
}
