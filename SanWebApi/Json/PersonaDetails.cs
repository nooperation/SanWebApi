using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class PersonaDetails
    {
        public string id { get; set; }
        public string handle { get; set; }
        public string name { get; set; }
        public string app_desc { get; set; }
        public object[] roles { get; set; }
        public string last_loc { get; set; }
    }

    public class PersonaDetails_AppDescOnly
    {
        public string app_desc { get; set; }
    }
}
