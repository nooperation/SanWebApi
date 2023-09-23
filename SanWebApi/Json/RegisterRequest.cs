namespace SanWebApi.Json
{
    public class RegisterRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool tos => true;
        public string verification_url => @"https://www.sansar.com/download";
        public string metadata { get; set; }

        public RegisterRequest(string username, string password)
        {
            var tempMetadata = new Metadata("");
            var metadataPayload = Newtonsoft.Json.JsonConvert.SerializeObject(tempMetadata);

            this.username = username;
            this.password = password;
            metadata = metadataPayload;
        }

        public class Metadata
        {
            public string source => "client";
            public string persona_name { get; set; }
            public Client_Configuration client_configuration { get; set; }

            public Metadata(string personaName)
            {
                persona_name = personaName;
                client_configuration = new Client_Configuration();
            }

            public override string ToString()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }
        }

        public class Client_Configuration
        {
            public bool is_first_time_user => true;

            public override string ToString()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }
        }
    }
}
