using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json.RegionConductor
{
    internal class EditRequest_v6
    {
        [JsonProperty("proto")]
        public string Proto { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
