using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanBot.Json
{
    public class LibraryResponse
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }

        public partial class Item
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("account_id")]
            public string AccountId { get; set; }

            [JsonProperty("persona_id")]
            public string PersonaId { get; set; }

            [JsonProperty("licensor_pid")]
            public string LicensorPid { get; set; }

            [JsonProperty("creation_time")]
            public string CreationTime { get; set; }

            [JsonProperty("modification_time")]
            public string ModificationTime { get; set; }

            [JsonProperty("compat_version")]
            public string CompatVersion { get; set; }

            [JsonProperty("licensor_label")]
            public string LicensorLabel { get; set; }

            [JsonProperty("licensee_label")]
            public string LicenseeLabel { get; set; }

            [JsonProperty("origin")]
            public long Origin { get; set; }

            [JsonProperty("origin_reference")]
            public string OriginReference { get; set; }

            [JsonProperty("state")]
            public long State { get; set; }

            [JsonProperty("revisions")]
            public Revision[] Revisions { get; set; }
        }

        public partial class Revision
        {
            [JsonProperty("asset_id")]
            public string AssetId { get; set; }

            [JsonProperty("asset_type")]
            public string AssetType { get; set; }

            [JsonProperty("asset_hint")]
            public long AssetHint { get; set; }

            [JsonProperty("thumbnail_asset_id")]
            public string ThumbnailAssetId { get; set; }

            [JsonProperty("license_asset_id")]
            public string LicenseAssetId { get; set; }

            [JsonProperty("capabilities")]
            public string[] Capabilities { get; set; }
        }
    }
}
