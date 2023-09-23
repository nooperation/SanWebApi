using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class SoftwareVersionsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
