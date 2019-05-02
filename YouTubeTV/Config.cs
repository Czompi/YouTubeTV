using Newtonsoft.Json;

namespace YouTubeTV
{
    public class Config
    {
        [JsonProperty("ActiveScreen", Required = Required.Always)]
        public int ActiveScreen;
    }
}