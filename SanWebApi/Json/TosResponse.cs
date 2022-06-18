using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanBot.Json
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

        public partial class PayloadClass
        {
            [JsonProperty("signed_tos")]
            public bool SignedTos { get; set; }
        }
    }
}
