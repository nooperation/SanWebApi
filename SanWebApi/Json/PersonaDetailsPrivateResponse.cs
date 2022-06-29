using System;

namespace SanWebApi.Json
{
    public class Backend
    {

        public class PersonaDetailsPrivateResponse
        {
            public string status { get; set; }
            public object[] message { get; set; }
            public object[] codes { get; set; }
            public PersonaDetailsPrivate payload { get; set; }

            public class PersonaDetailsPrivate
            {
                public string account_id { get; set; }
                public string id { get; set; }
                public string handle { get; set; }
                public string name { get; set; }
                public bool is_default { get; set; }
                public DateTime created { get; set; }
                public string integrator { get; set; }
            }
        }
    }
}
