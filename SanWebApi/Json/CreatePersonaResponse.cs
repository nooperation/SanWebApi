namespace SanWebApi.Json
{
    public class CreatePersonaResponse
    {
        public string status { get; set; }
        public object[] message { get; set; }
        public object[] codes { get; set; }
        public Payload payload { get; set; }


        public class Payload
        {
            public string account_id { get; set; }
            public string id { get; set; }
            public string handle { get; set; }
            public string name { get; set; }
            public bool is_default { get; set; }
            public DateTime created { get; set; }
            public string integrator { get; set; }
            public Errors errors { get; set; }
            public Suggestions suggestions { get; set; }
        }

        public class Errors
        {
            public string[] handle { get; set; }
            public object[] name { get; set; }
        }

        public class Suggestions
        {
            public string[] handle { get; set; }
            public object[] name { get; set; }
        }
    }
}
