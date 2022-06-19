using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class ProfileResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string status { get; set; }
            public string avatarImageUrl { get; set; }
            public string title { get; set; }
            public string id { get; set; }
            public string avatarId { get; set; }
            public string avatarHandle { get; set; }
            public string avatarName { get; set; }
            public string bio { get; set; }
            public string avatarImageAssetId { get; set; }
            public object chatAvatarUrl { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public object currentQuestId { get; set; }
            public int level { get; set; }
            public object[] staticRoles { get; set; }
        }
    }
}
