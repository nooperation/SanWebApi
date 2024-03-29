﻿using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class AccountConnectorResponse
    {
        [JsonProperty("connector_response")]
        public ConnectorResponseClass ConnectorResponse { get; set; }

        public class ConnectorResponseClass
        {
            [JsonProperty("status")]
            public long Status { get; set; }

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
