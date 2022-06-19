using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class SetProfileRequestAll
    {
        public Data data { get; set; }

        public class Data
        {
            public string bio { get; set; }
            public string avatarImageAssetId { get; set; }
        }

        public SetProfileRequestAll(string bio, string avatarImageAssetId)
        {
            this.data = new Data()
            {
                avatarImageAssetId = avatarImageAssetId,
                bio = bio
            };
        }
    }
}
