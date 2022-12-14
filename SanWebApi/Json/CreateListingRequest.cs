using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class CreateListingRequest
    {
        public Data data { get; set; }

        public CreateListingRequest(string inventoryItemId, string name, string description, string storeId, string categoryId)
        {
            data = new Data()
            {
                type = "product",
                attributes = new Attributes()
                {
                    name = name,
                    description = description,
                    status = "hidden",
                    inventoryItemId = inventoryItemId,
                },
                relationships = new Relationships()
                {
                    category = new RelationshipDataPayload()
                    {
                        data = new RelationshipData()
                        {
                            type = "category",
                            id = categoryId
                        }
                    },
                    store = new RelationshipDataPayload()
                    {
                        data = new RelationshipData()
                        {
                            type = "store",
                            id = storeId,
                        }
                    }
                }
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
            public string inventoryItemId { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string description { get; set; }
        }

        public class Relationships
        {
            public RelationshipDataPayload category { get; set; }
            public RelationshipDataPayload store { get; set; }
        }

        public class RelationshipDataPayload
        {
            public RelationshipData data { get; set; }
        }

        public class RelationshipData
        {
            public string type { get; set; }
            public string id { get; set; }
        }



    }
}
