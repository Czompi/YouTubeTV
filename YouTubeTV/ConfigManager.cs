using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace YouTubeTV
{
    internal class ConfigManager
    {
        internal static String cfgLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\YouTubeTV\settings.json";
        internal static Config InitConfig()
        {
            var loc = Path.GetDirectoryName(cfgLoc);
            if (!Directory.Exists(loc)) Directory.CreateDirectory(loc);
            Config cfg = null;
            String configFile = "";
            try
            {
                configFile = File.ReadAllText(cfgLoc);
            }
            catch (Exception)
            {
                int activeScreen = 0;
                var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Select((s, i) => new { Screen = s, Index = i}).Where(s => !s.Screen.Primary).FirstOrDefault();

                if (secondaryScreen != null) {
                    activeScreen = secondaryScreen.Index;
                }

                configFile = new JObject(
                    new JProperty("ActiveScreen", activeScreen)
                ).ToString();
                File.WriteAllText(cfgLoc, configFile);
            }
            cfg = JsonConvert.DeserializeObject<Config>(configFile);
            return cfg;
        }

        internal static void SaveConfig(Config config)
        {
            File.WriteAllText(cfgLoc, JObject.Parse(JsonConvert.SerializeObject(config)).ToString());
        }
    }
}