using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace YouTubeTV
{
    public partial class MainForm : Form
    {
        internal readonly ChromiumWebBrowser browser;
        public MainForm()
        {
            CefSettings settings = new CefSettings();
            settings.UserAgent = "SMART-TV; Tizen 4.0";
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\YouTubeTV\cache";
            CefSharp.Cef.Initialize(settings);
            InitializeComponent();
            this.BackColor = Color.FromArgb(40, 40, 40);
            Text = String.Format(Text, Settings.Version, Cef.ChromiumVersion, Cef.CefVersion);
            var browserSettings = new CefSharp.BrowserSettings();
            browserSettings.BackgroundColor = Cef.ColorSetARGB(255, 40, 40, 40);
            browser = new ChromiumWebBrowser("https://youtube.com/tv");
            browser.BrowserSettings = browserSettings;
            browser.Dock = DockStyle.Fill;
            browser.BackColor = Color.FromArgb(40, 40, 40);
            browser.KeyUp += Browser_KeyUp;
            Controls.Add(browser);
        }

        private void Browser_KeyUp(object sender, KeyEventArgs e)
        {
            MainForm_KeyUp(sender, e);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.F3 && e.Control)) return;
            throw new NotImplementedException();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
        }
    }
}
