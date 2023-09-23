using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class ProfilesResponse
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        public class Datum
        {
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("avatarImageUrl")]
            public Uri AvatarImageUrl { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("avatarId")]
            public string AvatarId { get; set; }

            [JsonProperty("avatarHandle")]
            public string AvatarHandle { get; set; }

            [JsonProperty("avatarName")]
            public string AvatarName { get; set; }

            [JsonProperty("bio")]
            public string Bio { get; set; }

            [JsonProperty("avatarImageAssetId")]
            public string AvatarImageAssetId { get; set; }

            [JsonProperty("createdAt")]
            public string CreatedAt { get; set; }

            [JsonProperty("updatedAt")]
            public string UpdatedAt { get; set; }

            [JsonProperty("currentQuestId")]
            public object CurrentQuestId { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }
        }

        public class Error
        {
            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("detail")]
            public string Detail { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("expose")]
            public bool Expose { get; set; }
        }
    }
}