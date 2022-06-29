namespace SanWebApi.Json
{
    public class ConnectorResponse
    {
        public Payload connector_response { get; set; }

        public class Payload
        {
            public int status { get; set; }
            public long secret { get; set; }
            public string host { get; set; }
            public int tcp_port { get; set; }
            public int udp_port { get; set; }
        }
    }
}
