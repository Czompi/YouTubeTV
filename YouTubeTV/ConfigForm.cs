using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeTV
{
    public partial class ConfigForm : Form
    {
        Config config = null;
        public ConfigForm()
        {
            InitializeComponent();
            Text = string.Format(Text, Settings.Version);
            int activeScreen = 0;
            var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Select((s, i) => new { Screen = s, Index = i }).Where(s => !s.Screen.Primary).FirstOrDefault();

            if (secondaryScreen != null)
            {
                activeScreen = secondaryScreen.Index;
            }
            selectScreenCBX.Items.AddRange(System.Windows.Forms.Screen.AllScreens.Select((s, i) => new { Screen = s, Index = i }).Select(s => (s.Index+1) + ". " + DeviceInfo.Display(s.Screen, s.Index).DeviceString + " ["+ s.Screen.DeviceName + "] (" + s.Screen.Bounds.Width + "x" + s.Screen.Bounds.Height + ")").ToArray());
            
            config = ConfigManager.InitConfig();
            selectScreenCBX.SelectedIndex = config.ActiveScreen;
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            if (config.ActiveScreen != selectScreenCBX.SelectedIndex)
            {
                config.ActiveScreen = selectScreenCBX.SelectedIndex;
                ConfigManager.SaveConfig(config);
            }
            Application.Exit();
        }
    }
}
