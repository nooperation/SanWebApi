using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class GetInstancesResponse
    {
        public string sansar_uri { get; set; }
        public Instance[] instances { get; set; }
    }

    public class Instance
    {
        public int limit { get; set; }
        public int current { get; set; }
        public string instance_uri { get; set; }
        public bool broadcaster { get; set; }
        public string instance_name { get; set; }
    }
}
