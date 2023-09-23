namespace SanWebApi.Json
{
    public class OrderItemResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string type { get; set; }
            public Attributes attributes { get; set; }
            public Relationship[] relationships { get; set; }
        }

        public class Attributes
        {
            public string id { get; set; }
            public string transactionId { get; set; }
            public string invoiceId { get; set; }
            public string transferId { get; set; }
            public string status { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public Buyer buyer { get; set; }
            public Lineitem[] lineItems { get; set; }
        }

        public class Buyer
        {
            public string personaId { get; set; }
            public string personaName { get; set; }
            public string personaHandle { get; set; }
        }

        public class Lineitem
        {
            public string id { get; set; }
            public string itemId { get; set; }
            public string itemName { get; set; }
            public string itemType { get; set; }
            public string licenseAssetId { get; set; }
            public int amount { get; set; }
            public int fee { get; set; }
            public string currency { get; set; }
            public Merchant merchant { get; set; }
        }

        public class Merchant
        {
            public string personaId { get; set; }
            public string personaName { get; set; }
            public string personaHandle { get; set; }
        }

        public class Relationship
        {
            public Data1 data { get; set; }
        }

        public class Data1
        {
            public string id { get; set; }
            public string type { get; set; }
        }
    }
}
