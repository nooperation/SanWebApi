using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class ExtractionResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domains")]
        public DomainsClass Domains { get; set; }

        [JsonProperty("config")]
        public ConfigClass Config { get; set; }

        [JsonProperty("services")]
        public ServicesClass Services { get; set; }

        public class ConfigClass
        {
            [JsonProperty("sansar_client_id")]
            public SansarClientId SansarClientId { get; set; }
        }

        public class SansarClientId
        {
            [JsonProperty("v1")]
            public string V1 { get; set; }
        }

        public class DomainsClass
        {
        }

        public class ServicesClass
        {
            [JsonProperty("accounts")]
            public Accounts Accounts { get; set; }

            [JsonProperty("accounts-customer")]
            public Accounts AccountsCustomer { get; set; }

            [JsonProperty("auth")]
            public Auth Auth { get; set; }

            [JsonProperty("billing-info")]
            public Accounts BillingInfo { get; set; }

            [JsonProperty("homepage")]
            public Accounts Homepage { get; set; }

            [JsonProperty("login-frontend")]
            public Accounts LoginFrontend { get; set; }

            [JsonProperty("payments")]
            public Accounts Payments { get; set; }

            [JsonProperty("personas")]
            public Personas Personas { get; set; }

            [JsonProperty("personas-ops")]
            public Personas PersonasOps { get; set; }

            [JsonProperty("personas-search")]
            public PersonasSearch PersonasSearch { get; set; }

            [JsonProperty("register-frontend")]
            public Accounts RegisterFrontend { get; set; }

            [JsonProperty("registration")]
            public Accounts Registration { get; set; }

            [JsonProperty("subscriptions")]
            public Accounts Subscriptions { get; set; }

            [JsonProperty("subscriptions-ops")]
            public Accounts SubscriptionsOps { get; set; }

            [JsonProperty("tos")]
            public Accounts Tos { get; set; }
        }

        public class Accounts
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class Auth
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }

            [JsonProperty("v2")]
            public Uri V2 { get; set; }

            [JsonProperty("v3")]
            public Uri V3 { get; set; }

            [JsonProperty("v4")]
            public Uri V4 { get; set; }
        }

        public class Personas
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }

            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public class PersonasSearch
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }
    }
}
