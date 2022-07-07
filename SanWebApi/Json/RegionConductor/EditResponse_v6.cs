using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json.RegionConductor
{
    public class EditResponse_v6
    {
        [JsonProperty("editserver_response")]
        public EditserverResponseClass EditserverResponse { get; set; }

        [JsonProperty("editserver_uri")]
        public string EditserverUri { get; set; }

        public class EditserverResponseClass
        {
            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("secret")]
            public long Secret { get; set; }

            [JsonProperty("host")]
            public string Host { get; set; }

            [JsonProperty("tcp_port")]
            public long TcpPort { get; set; }

            [JsonProperty("udp_port")]
            public long UdpPort { get; set; }
        }
    }
}
