using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class BalanceResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public int balance { get; set; }
            public int earned { get; set; }
            public int general { get; set; }
            public string currency { get; set; }
        }

    }
}
