using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class SoftwareVersionsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
