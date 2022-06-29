using System;

namespace SanWebApi.Json
{
    public class ExperienceResponse
    {
        public Experience[] experiences { get; set; }

        public class Experience
        {
            public string id { get; set; }
            public string account_id { get; set; }
            public string persona_id { get; set; }
            public string persona_handle { get; set; }
            public string persona_name { get; set; }
            public string name { get; set; }
            public string compat_version { get; set; }
            public string description { get; set; }
            public string handle { get; set; }
            public bool listed { get; set; }
            public DateTime modification_time { get; set; }
            public DateTime creation_time { get; set; }
            public string scene_asset_id { get; set; }
            public string thumbnail_asset_id { get; set; }
            public string origin_reference { get; set; }
            public string uri { get; set; }
            public int curation { get; set; }
            public int access_controls { get; set; }
            public object[] whitelist { get; set; }
            public object[] banlist { get; set; }
            public string conductor_role_default { get; set; }
            public int conductor_user_max { get; set; }
            public string broadcaster_role { get; set; }
            public int conductor_broadcaster_user_max { get; set; }
            public int conductor_clone_user_max { get; set; }
            public string memo { get; set; }
            public string event_reference { get; set; }
        }
    }
}
