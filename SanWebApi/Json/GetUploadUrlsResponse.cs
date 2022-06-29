using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class GetUploadUrlsResponse
    {
        public Asset[] assets { get; set; }

        public class Asset
        {
            public string asset_name { get; set; }
            public bool exists { get; set; }
            public string asset_type { get; set; }
            public string content_type { get; set; }
            public string etag { get; set; }
            public string url { get; set; }
            public Headers headers { get; set; }
        }

        public class Headers
        {
            [JsonProperty("Content-Encoding")]
            public string[] ContentEncoding { get; set; }


            [JsonProperty("Content-Type")]
            public string[] ContentType { get; set; }


            [JsonProperty("X-Amz-Acl")]
            public string[] XAmzAcl { get; set; }


            [JsonProperty("X-Amz-Meta-Be-At")]
            public string[] XAmzMetaBeAt { get; set; }


            [JsonProperty("X-Amz-Meta-Be-Cap")]
            public string[] XAmzMetaBeCap { get; set; }


            [JsonProperty("X-Amz-Meta-Be-Vers")]
            public string[] XAmzMetaBeVers { get; set; }
        }
    }

}
