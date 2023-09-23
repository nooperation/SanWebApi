using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class PersonasByAccountResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public List<object> Message { get; set; }

        [JsonProperty("codes")]
        public List<object> Codes { get; set; }

        [JsonProperty("payload")]
        public List<PayloadClass> Payload { get; set; }

        public class PayloadClass
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("handle")]
            public string Handle { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("is_default")]
            public bool IsDefault { get; set; }
        }
    }
}
