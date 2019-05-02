using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeTV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            #region Check `Visual C++ Redistributable for Visual Studio 2017` installation
            String vcredis_loc = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\msvcr120.dll";
            if (!File.Exists(vcredis_loc))
            {
                MessageBox.Show("This application requires Visual C++ Redistributable for Visual Studio 2017. You will be navigated to Microsoft's site, where you could get it.", "YouTubeTV " + Settings.Version);
                Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=48145");
                return;
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config cfg = ConfigManager.InitConfig();
            if (args.Length == 0 || (args.Length == 1 && args[0] == "--main"))
            {

                MainForm mainForm = new MainForm();
                Screen[] screens = Screen.AllScreens;

                MaximizeForm(mainForm, screens[cfg.ActiveScreen]);

                Application.Run(mainForm);
            }
            else if (args.Length == 1 && args[0] == "--config")
            {
                ConfigForm configForm = new ConfigForm();
                Application.Run(configForm);
            }
        }
        private static void MaximizeForm(Form form, Screen screen)
        {
            var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Where(s => !s.Primary).FirstOrDefault();

            if (screen != null)
            {
                form.StartPosition = FormStartPosition.Manual;
                form.SetBounds(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height);
            }
        }
    }
}
