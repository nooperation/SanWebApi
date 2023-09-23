using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class ProfileDetailsResponse
    {
        [JsonProperty("data")]
        public DataClass Data { get; set; }

        public class DataClass
        {
            [JsonProperty("xp")]
            public Xp Xp { get; set; }
        }

        public class Xp
        {
            [JsonProperty("prevLevel")]
            public long PrevLevel { get; set; }

            [JsonProperty("nextLevel")]
            public long NextLevel { get; set; }

            [JsonProperty("buckets")]
            public Buckets Buckets { get; set; }
        }

        public class Buckets
        {
            [JsonProperty("Total")]
            public BucketData Total { get; set; }

            [JsonProperty("General")]
            public BucketData General { get; set; }

            [JsonProperty("Explorer")]
            public BucketData Explorer { get; set; }

            [JsonProperty("Socialite")]
            public BucketData Socialite { get; set; }

            [JsonProperty("Creator")]
            public BucketData Creator { get; set; }
        }

        public class BucketData
        {
            [JsonProperty("amount")]
            public long Amount { get; set; }
        }
    }
}
