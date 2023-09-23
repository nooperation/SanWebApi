using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class WebApiResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domains")]
        public DomainsClass Domains { get; set; }

        [JsonProperty("services")]
        public ServicesClass Services { get; set; }

        public class DomainsClass
        {
            [JsonProperty("backend")]
            public Backend Backend { get; set; }

            [JsonProperty("extraction")]
            public Extraction Extraction { get; set; }
        }

        public class Backend
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }

            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public class Extraction
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public class ServicesClass
        {
            [JsonProperty("account")]
            public Account Account { get; set; }

            [JsonProperty("subscriptions-frontend")]
            public Account SubscriptionsFrontend { get; set; }

            [JsonProperty("atlas")]
            public Account Atlas { get; set; }

            [JsonProperty("atlas-api")]
            public Api AtlasApi { get; set; }

            [JsonProperty("atlas-frontend")]
            public Account AtlasFrontend { get; set; }

            [JsonProperty("community-frontend")]
            public Account CommunityFrontend { get; set; }

            [JsonProperty("events-api")]
            public EventsApi EventsApi { get; set; }

            [JsonProperty("help-frontend")]
            public Account HelpFrontend { get; set; }

            [JsonProperty("ps-api")]
            public Account PsApi { get; set; }

            [JsonProperty("profiles-api")]
            public Backend ProfilesApi { get; set; }

            [JsonProperty("register-frontend")]
            public Extraction RegisterFrontend { get; set; }

            [JsonProperty("reporter-frontend")]
            public Account ReporterFrontend { get; set; }

            [JsonProperty("reportissue-frontend")]
            public Account ReportissueFrontend { get; set; }

            [JsonProperty("reviews-api")]
            public Api ReviewsApi { get; set; }

            [JsonProperty("sansar-frontend")]
            public Account SansarFrontend { get; set; }

            [JsonProperty("store")]
            public Account Store { get; set; }

            [JsonProperty("store-api")]
            public Account StoreApi { get; set; }

            [JsonProperty("search-service")]
            public Account SearchService { get; set; }

            [JsonProperty("marketplace-api")]
            public Api MarketplaceApi { get; set; }

            [JsonProperty("commerce-service")]
            public Backend CommerceService { get; set; }

            [JsonProperty("ticketing-api")]
            public Backend TicketingApi { get; set; }

            [JsonProperty("support-api")]
            public Account SupportApi { get; set; }

            [JsonProperty("apidocs")]
            public Account Apidocs { get; set; }

            [JsonProperty("util")]
            public Account Util { get; set; }

            [JsonProperty("tracking")]
            public Account Tracking { get; set; }

            [JsonProperty("ga")]
            public Account Ga { get; set; }

            [JsonProperty("config")]
            public Config Config { get; set; }

            [JsonProperty("exmox")]
            public Account Exmox { get; set; }
        }

        public class Account
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class Api
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }

            [JsonProperty("v2")]
            public Uri V2 { get; set; }

            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public class Config
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class EventsApi
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }

            [JsonProperty("v2")]
            public Uri V2 { get; set; }

            [JsonProperty("v3")]
            public Uri V3 { get; set; }

            [JsonProperty("v4")]
            public Uri V4 { get; set; }

            [JsonProperty("v5")]
            public Uri V5 { get; set; }
        }
    }
}
