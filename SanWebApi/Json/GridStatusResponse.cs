using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class GridStatusResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
