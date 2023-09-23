namespace SanWebApi.Json
{

    public class AddReviewRequest
    {
        public Data data { get; set; }

        public AddReviewRequest(string itemId, string itemType = "experience", int rating = 5)
        {
            data = new Data()
            {
                type = "review",
                attributes = new Attributes()
                {
                    item = new Item()
                    {
                        id = itemId,
                        name = itemId,
                        type = itemType
                    },
                    rating = rating
                }
            };
        }

        public class Data
        {
            public string type { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Attributes
        {
            public Item item { get; set; }
            public int rating { get; set; }
        }

        public class Item
        {
            public string type { get; set; }
            public string id { get; set; }
            public string name { get; set; }
        }
    }
}
