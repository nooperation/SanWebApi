using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class OrderItemRequest
    {
        public Data data { get; set; }

        public OrderItemRequest(string productId)
        {
            var newTrasnactionId = System.Guid.NewGuid().ToString();

            this.data = new Data()
            {
                attributes = new Attributes()
                {
                    transactionId = newTrasnactionId
                },
                relationships = new Relationships()
                {
                    product = new Product()
                    {
                        data = new Data1()
                        {
                            id = productId,
                            type = "product"
                        }
                    }
                },
                type = "order",
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
            public string transactionId { get; set; }
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
