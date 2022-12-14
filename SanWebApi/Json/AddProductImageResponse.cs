using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class AddProductImageResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Relationships relationships { get; set; }
        }

        public class Attributes
        {
            public int ordinal { get; set; }
            public string url { get; set; }
            public Sizes sizes { get; set; }
        }

        public class Sizes
        {
            public Large large { get; set; }
            public Medium medium { get; set; }
            public Preview preview { get; set; }
            public Thumb thumb { get; set; }
            public Tiny tiny { get; set; }
        }

        public class Large
        {
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Medium
        {
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Preview
        {
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Thumb
        {
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Tiny
        {
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Relationships
        {
            public Creator creator { get; set; }
        }

        public class Creator
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
