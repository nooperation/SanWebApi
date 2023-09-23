using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class PersonaSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public List<string> Message { get; set; }

        [JsonProperty("codes")]
        public List<string> Codes { get; set; }

        [JsonProperty("payload")]
        public List<PayloadCass> Payload { get; set; }

        public class PayloadCass
        {
            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("handle")]
            public string Handle { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("is_default")]
            public bool IsDefault { get; set; }
        }
    }
}
