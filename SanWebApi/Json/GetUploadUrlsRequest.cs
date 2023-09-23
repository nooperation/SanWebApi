namespace SanWebApi.Json
{
    public class GetUploadUrlsRequest
    {
        public List<Asset> assets { get; set; } = new List<Asset>();

        public void AddImage(string filename)
        {
            assets.Add(new Asset()
            {
                asset_name = filename,
                asset_type = "DEPRECATED",
                content_type = "image/png"
            });
        }

        public void AddRaw(string filename)
        {
            assets.Add(new Asset()
            {
                asset_name = filename,
                asset_type = "DEPRECATED",
                content_type = "application/octet-stream"
            });
        }

        public class Asset
        {
            public string asset_name { get; set; }
            public string asset_type { get; set; }
            public string content_type { get; set; }
        }
    }
}
