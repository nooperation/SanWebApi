using System;

namespace SanWebApi.Json
{
    public class InventoryResponse
    {
        public Item[] items { get; set; }

        public class Item
        {
            public string id { get; set; }
            public string account_id { get; set; }
            public string persona_id { get; set; }
            public string licensor_pid { get; set; }
            public DateTime creation_time { get; set; }
            public DateTime modification_time { get; set; }
            public string compat_version { get; set; }
            public string licensor_label { get; set; }
            public string licensee_label { get; set; }
            public int origin { get; set; }
            public string origin_reference { get; set; }
            public int state { get; set; }
            public Revision[] revisions { get; set; }
        }

        public class Revision
        {
            public string asset_id { get; set; }
            public string asset_type { get; set; }
            public int asset_hint { get; set; }
            public string thumbnail_asset_id { get; set; }
            public string license_asset_id { get; set; }
            public string[] capabilities { get; set; }
        }
    }
}
