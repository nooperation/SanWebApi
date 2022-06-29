using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class IsEUResponse
    {
        [JsonProperty("europeanUnion")]
        public bool EuropeanUnion { get; set; }
    }
}
