namespace SanWebApi.Json
{
    public class CreateListingResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Links links { get; set; }
            public Relationships relationships { get; set; }
        }

        public class Attributes
        {
            public string[] capabilities { get; set; }
            public string compatVersion { get; set; }
            public DateTime createdAt { get; set; }
            public object description { get; set; }
            public object featuredOn { get; set; }
            public string inventoryName { get; set; }
            public License license { get; set; }
            public string name { get; set; }
            public int price { get; set; }
            public int resalePrice { get; set; }
            public string status { get; set; }
            public object[] tags { get; set; }
            public object vendorDescription { get; set; }
            public object vendorUrl { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class License
        {
            public object[] payouts { get; set; }
            public Root root { get; set; }
        }

        public class Root
        {
            public bool canExtract { get; set; }
            public bool canModify { get; set; }
            public int price { get; set; }
        }

        public class Links
        {
            public Store store { get; set; }
        }

        public class Store
        {
            public string listing { get; set; }
            public string edit { get; set; }
        }

        public class Relationships
        {
            public Category category { get; set; }
            public Creator creator { get; set; }
            public Store1 store { get; set; }
        }

        public class Category
        {
            public Data1 data { get; set; }
        }

        public class Data1
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Creator
        {
            public Data2 data { get; set; }
        }

        public class Data2
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Store1
        {
            public Data3 data { get; set; }
        }

        public class Data3
        {
            public string id { get; set; }
            public string type { get; set; }
        }

    }
}
