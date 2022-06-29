using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class ScreenshotsResponse
    {
        public Datum[] data { get; set; }
        public Meta meta { get; set; }

        public class Meta
        {
            public int total { get; set; }
            public int page { get; set; }
            public int perPage { get; set; }
            public int pages { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string personaId { get; set; }
            public string personaHandle { get; set; }
            public string personaName { get; set; }
            public string experienceHandle { get; set; }
            public string experiencePersonaHandle { get; set; }
            public string imageId { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public object deletedAt { get; set; }
            public Size[] sizes { get; set; }
            public Links links { get; set; }
        }

        public class Links
        {
            public string view { get; set; }
        }

        public class Size
        {
            public int? width { get; set; }
            public string size { get; set; }
            public string url { get; set; }
        }
    }
}
