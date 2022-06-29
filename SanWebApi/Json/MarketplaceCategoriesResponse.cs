using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class MarketplaceCategoriesResponse
    {
        [JsonProperty("data")]
        public Datum[] data { get; set; }

        public class Datum
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("depth")]
            public int Depth { get; set; }

            [JsonProperty("left")]
            public int Left { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("right")]
            public int Right { get; set; }

            [JsonProperty("parentId")]
            public string ParentId { get; set; }

            [JsonProperty("slug")]
            public string Slug { get; set; }
        }
    }
}
