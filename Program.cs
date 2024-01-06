using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace ColorfulLedKeyboardSet
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            String name = AppDomain.CurrentDomain.FriendlyName;
            String path = AppDomain.CurrentDomain.BaseDirectory;
            RegistryKey starts = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new Form1();
            if (starts.GetValue(name) != null)
            {
                form.WindowState = FormWindowState.Minimized;
                form.ShowInTaskbar = false; 
            }
            Application.Run(form);
        }
    }
}
