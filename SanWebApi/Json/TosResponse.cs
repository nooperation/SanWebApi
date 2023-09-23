using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class TosResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public object[] Message { get; set; }

        [JsonProperty("codes")]
        public object[] Codes { get; set; }

        [JsonProperty("payload")]
        public PayloadClass Payload { get; set; }

        public class PayloadClass
        {
            [JsonProperty("signed_tos")]
            public bool SignedTos { get; set; }
        }
    }
}
