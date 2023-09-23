using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class ExtTrackingPayload
    {
        [JsonProperty("event-name")]
        public string eventname { get; set; }

        [JsonProperty("client-timestamp")]
        public DateTime clienttimestamp { get; set; }

        [JsonProperty("client-version")]
        public string clientversion { get; set; }

        [JsonProperty("display_mode")]
        public string display_mode { get; set; }

        [JsonProperty("grid")]
        public string grid { get; set; }

        [JsonProperty("tracker-id")]
        public string trackerid { get; set; }

        [JsonProperty("mac-address")]
        public string macaddress { get; set; }

        [JsonProperty("page-id")]
        public string pageid { get; set; }
    }
}
