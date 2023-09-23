namespace SanWebApi.Json
{
    public class RegisterResponse
    {
        public string status { get; set; }
        public string[] message { get; set; }
        public string[] codes { get; set; }
        public Payloada payload { get; set; }

        public class Payloada
        {
            public string metadata { get; set; }
            public Errors errors { get; set; }
        }

        public class Errors
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
