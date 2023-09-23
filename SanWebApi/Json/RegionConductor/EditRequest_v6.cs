using Newtonsoft.Json;

namespace SanWebApi.Json.RegionConductor
{
    internal class EditRequest_v6
    {
        [JsonProperty("proto")]
        public string Proto { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
