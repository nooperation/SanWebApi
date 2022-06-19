using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class PersonasByAccountResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public object[] Message { get; set; }

        [JsonProperty("codes")]
        public object[] Codes { get; set; }

        [JsonProperty("payload")]
        public PayloadClass[] Payload { get; set; }

        public partial class PayloadClass
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
