namespace SanWebApi.Json
{
    public class AddProductImageRequest
    {
        public Data data { get; set; }

        public AddProductImageRequest(string imageId, string productId)
        {
            data = new Data()
            {
                type = "image",
                attributes = new Attributes()
                {
                    ordinal = 0,
                    imagedId = productId,
                    imagedType = "product",
                    url = $"https://sansarweb-input-production.s3.amazonaws.com/marketplace/listings/{imageId}.png",
                },
                relationships = new Relationships()
                {
                    product = new Product()
                    {
                        data = new Data1()
                        {
                            id = productId,
                            type = "product",
                        }
                    }
                },
            };
        }

        public class Data
        {
            public string type { get; set; }
            public Attributes attributes { get; set; }
            public Relationships relationships { get; set; }
        }

        public class Attributes
        {
            public int ordinal { get; set; }
            public string imagedId { get; set; }
            public string imagedType { get; set; }
            public string url { get; set; }
        }

        public class Relationships
        {
            public Product product { get; set; }
        }

        public class Product
        {
            public Data1 data { get; set; }
        }

        public class Data1
        {
            public string type { get; set; }
            public string id { get; set; }
        }

    }
}
