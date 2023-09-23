using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class IsEUResponse
    {
        [JsonProperty("europeanUnion")]
        public bool EuropeanUnion { get; set; }
    }
}
