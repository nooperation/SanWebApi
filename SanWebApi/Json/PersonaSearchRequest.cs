using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class PersonaSearchRequest
    {
        [JsonProperty("term")]
        public string Term { get; set; }
    }
}
