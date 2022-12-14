using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class SetListingImageRequest
    {
        public Data data { get; set; }

        public SetListingImageRequest(string imageId)
        {
            data = new Data()
            {
                relationships = new Relationships()
                {
                    defaultImage = new Defaultimage()
                    {
                        data = new Data1()
                        {
                            type = "image",
                            id = imageId
                        }
                    }
                }
            };
        }

        public class Data
        {
            public Relationships relationships { get; set; }
        }

        public class Relationships
        {
            public Defaultimage defaultImage { get; set; }
        }

        public class Defaultimage
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
