using Newtonsoft.Json;

namespace EnshroudedServerManager.Models
{
    public class Settings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("saveDirectory")]
        public string SaveDirectory { get; set; }

        [JsonProperty("logDirectory")]
        public string LogDirectory { get; set; }

        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("gamePort")]
        public int GamePort { get; set; }

        [JsonProperty("queryPort")]
        public int QueryPort { get; set; }

        [JsonProperty("slotCount")]
        public int SlotCount { get; set; }
        
    }
}
