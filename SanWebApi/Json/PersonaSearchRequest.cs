using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SanWebApi.Json
{
    public class PersonaSearchRequest
    {
        [JsonProperty("term")]
        public string Term { get; set; }
    }
}
