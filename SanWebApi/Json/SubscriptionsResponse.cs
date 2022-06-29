using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class SubscriptionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public List<object> Message { get; set; }

        [JsonProperty("codes")]
        public List<object> Codes { get; set; }

        [JsonProperty("payload")]
        public PayloadClass Payload { get; set; }

        public class PayloadClass
        {
            [JsonProperty("account_id")]
            public string AccountId { get; set; }

            [JsonProperty("product")]
            public Product Product { get; set; }

            [JsonProperty("delinquent")]
            public bool Delinquent { get; set; }

            [JsonProperty("start_billing_cycle")]
            public string StartBillingCycle { get; set; }

            [JsonProperty("end_billing_cycle")]
            public string EndBillingCycle { get; set; }

            [JsonProperty("last_billed")]
            public string LastBilled { get; set; }

            [JsonProperty("level_change_request")]
            public string LevelChangeRequest { get; set; }

            [JsonProperty("payment_method_id")]
            public string PaymentMethodId { get; set; }

            [JsonProperty("integrator")]
            public string Integrator { get; set; }

            [JsonProperty("credits")]
            public List<object> Credits { get; set; }
        }

        public class Product
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("price")]
            public long Price { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("months")]
            public long Months { get; set; }
        }
    }
}
