namespace SanWebApi.Json
{
    public class PersonaCollectionResponse
    {
        public string status { get; set; }
        public object[] message { get; set; }
        public object[] codes { get; set; }
        public PersonaResponse.Payload[] payload { get; set; }
    }

    public class PersonaResponse
    {
        public string status { get; set; }
        public object[] message { get; set; }
        public object[] codes { get; set; }
        public Payload payload { get; set; }

        public class Payload
        {
            public string id { get; set; }
            public string handle { get; set; }
            public string name { get; set; }
            public bool is_default { get; set; }
        }
    }
}
