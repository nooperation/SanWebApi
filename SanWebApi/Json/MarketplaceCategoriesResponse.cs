using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class MarketplaceCategoriesResponse
    {
        public Datum[] data { get; set; }

        public class Datum
        {
            public string id { get; set; }
            public int depth { get; set; }
            public int left { get; set; }
            public string name { get; set; }
            public int right { get; set; }
            public string parentId { get; set; }
            public string slug { get; set; }
        }
    }
}
