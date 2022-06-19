using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class PersonaPrivateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        [JsonProperty("roles")]
        public object[] Roles { get; set; }

        [JsonProperty("last_loc")]
        public string LastLoc { get; set; }
    }
}
