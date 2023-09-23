using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class BalanceResponse
    {
        [JsonProperty("data")]
        public DataClass Data { get; set; }

        public class DataClass
        {
            [JsonProperty("balance")]
            public int Balance { get; set; }

            [JsonProperty("earned")]
            public int Earned { get; set; }

            [JsonProperty("general")]
            public int General { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }
        }

    }
}
