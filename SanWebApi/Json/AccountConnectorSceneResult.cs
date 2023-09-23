using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class AccountConnectorSceneResult
    {
        [JsonProperty("region_response")]
        public Response RegionResponse { get; set; }

        [JsonProperty("voice_response")]
        public Response VoiceResponse { get; set; }

        [JsonProperty("avatar_texture_max")]
        public int AvatarTextureMax { get; set; }

        [JsonProperty("max_avatar_count")]
        public int MaxAvatarCount { get; set; }

        [JsonProperty("scene_uri")]
        public string SceneUri { get; set; }

        [JsonProperty("world_definition_id")]
        public string WorldDefinitionId { get; set; }

        public class Response
        {
            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("secret")]
            public uint Secret { get; set; }

            [JsonProperty("host")]
            public string Host { get; set; }

            [JsonProperty("tcp_port")]
            public int TcpPort { get; set; }

            [JsonProperty("udp_port")]
            public int UdpPort { get; set; }
        }
    }


}
