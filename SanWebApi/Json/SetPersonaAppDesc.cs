using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class SetPersonaAppDesc
    {
        public string app_desc { get; set; }
    }

    public class PersonaAppDesc
    {
        public string avatarAssetId { get; set; }
        public string avatarInventoryId { get; set; }
    }
}
