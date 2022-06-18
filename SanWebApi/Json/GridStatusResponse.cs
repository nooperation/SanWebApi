﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanBot.Json
{
    public class GridStatusResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}