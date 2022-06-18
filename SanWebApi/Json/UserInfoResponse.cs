using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanBot.Json
{
    public class UserInfoResponse
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
            [JsonProperty("account_id")]
            public string AccountId { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("is_blocked")]
            public bool IsBlocked { get; set; }

            [JsonProperty("integrator")]
            public string Integrator { get; set; }

            [JsonProperty("created")]
            public string Created { get; set; }
        }
    }
}
