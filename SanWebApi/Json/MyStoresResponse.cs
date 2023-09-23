namespace SanWebApi.Json
{
    public class MyStoresResponse
    {
        public Datum[] data { get; set; }
        public Included[] included { get; set; }

        public class Datum
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Links links { get; set; }
            public Relationships relationships { get; set; }
        }

        public class Attributes
        {
            public DateTime createdAt { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Links
        {
            public string storePage { get; set; }
        }

        public class Relationships
        {
            public Creator creator { get; set; }
        }

        public class Creator
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Included
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes1 attributes { get; set; }
        }

        public class Attributes1
        {
            public string personaId { get; set; }
            public string personaHandle { get; set; }
            public string personaName { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

    }
}
