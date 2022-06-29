using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class PopularExperiencesResponse
    {
        public Meta meta { get; set; }
        public Experience[] data { get; set; }

        public class Meta
        {
            public int count { get; set; }
            public int page { get; set; }
            public int perPage { get; set; }
            public int total { get; set; }
            public int pages { get; set; }
        }

        public class Experience
        {
            public string id { get; set; }
            public int accessControls { get; set; }
            public string compatVersion { get; set; }
            public int curation { get; set; }
            public string description { get; set; }
            public int headCount { get; set; }
            public string handle { get; set; }
            public string name { get; set; }
            public string personaName { get; set; }
            public string personaHandle { get; set; }
            public string personaId { get; set; }
            public string sceneAssetId { get; set; }
            public string thumbnailAssetId { get; set; }
            public string uri { get; set; }
            public int reviewCount { get; set; }
            public bool listed { get; set; }
            public Image image { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Image
        {
            public string id { get; set; }
            public string url { get; set; }
            public string assetId { get; set; }
            public ImageSize[] sizes { get; set; }
        }

        public class ImageSize
        {
            public string size { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }
    }
}
