using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class MarketplaceApi_ProductsResponse
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("meta")]
        public MetaClass Meta { get; set; }

        public class Datum
        {
            [JsonProperty("capabilities")]
            public List<string> Capabilities { get; set; }

            [JsonProperty("createdAt")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("featuredOn")]
            public object FeaturedOn { get; set; }

            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("inventoryName")]
            public string InventoryName { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("price")]
            public long Price { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("updatedAt")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("category")]
            public Category Category { get; set; }

            [JsonProperty("creator")]
            public Creator Creator { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("defaultImage")]
            public DefaultImage DefaultImage { get; set; }

            [JsonProperty("reviewSummary", NullValueHandling = NullValueHandling.Ignore)]
            public ReviewSummary ReviewSummary { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("editUrl")]
            public Uri EditUrl { get; set; }

            [JsonProperty("license")]
            public object License { get; set; }

            [JsonProperty("resalePrice")]
            public long ResalePrice { get; set; }
        }

        public class Category
        {
            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("left")]
            public long Left { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("right")]
            public long Right { get; set; }

            [JsonProperty("slug")]
            public string Slug { get; set; }
        }

        public class Creator
        {
            [JsonProperty("personaHandle")]
            public string PersonaHandle { get; set; }

            [JsonProperty("personaName")]
            public string PersonaName { get; set; }

            [JsonProperty("personaId")]
            public Guid PersonaId { get; set; }
        }

        public class DefaultImage
        {
            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("sizes")]
            public Sizes Sizes { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }

        public class Sizes
        {
            [JsonProperty("large")]
            public Large Large { get; set; }

            [JsonProperty("medium")]
            public Large Medium { get; set; }

            [JsonProperty("preview")]
            public Large Preview { get; set; }

            [JsonProperty("thumb")]
            public Large Thumb { get; set; }

            [JsonProperty("tiny")]
            public Large Tiny { get; set; }
        }

        public class Large
        {
            [JsonProperty("width")]
            public long Width { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }

        public class ReviewSummary
        {
            [JsonProperty("averageRating")]
            public long AverageRating { get; set; }

            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("reviewCount")]
            public long ReviewCount { get; set; }

            [JsonProperty("totalRating")]
            public long TotalRating { get; set; }
        }

        public class Store
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("creator")]
            public Creator Creator { get; set; }
        }

        public class MetaClass
        {
            [JsonProperty("aggregations")]
            public Aggregations Aggregations { get; set; }

            [JsonProperty("page")]
            public long Page { get; set; }

            [JsonProperty("pages")]
            public long Pages { get; set; }

            [JsonProperty("perPage")]
            public long PerPage { get; set; }

            [JsonProperty("total")]
            public long Total { get; set; }
        }

        public class Aggregations
        {
            [JsonProperty("capabilities")]
            public Capabilities Capabilities { get; set; }

            [JsonProperty("categories")]
            public Categories Categories { get; set; }
        }

        public class Capabilities
        {
            [JsonProperty("doc_count_error_upper_bound")]
            public long DocCountErrorUpperBound { get; set; }

            [JsonProperty("sum_other_doc_count")]
            public long SumOtherDocCount { get; set; }

            [JsonProperty("buckets")]
            public List<Bucket> Buckets { get; set; }
        }

        public class Bucket
        {
            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("doc_count")]
            public long DocCount { get; set; }
        }

        public class Categories
        {
            [JsonProperty("doc_count_error_upper_bound")]
            public long DocCountErrorUpperBound { get; set; }

            [JsonProperty("sum_other_doc_count")]
            public long SumOtherDocCount { get; set; }

            [JsonProperty("buckets")]
            public List<Bucket> Buckets { get; set; }
        }
    }
}
