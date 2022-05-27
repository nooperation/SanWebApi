using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanBot.Json
{
    public class ExperimentsResponse
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        public partial class Datum
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("variantId")]
            public long VariantId { get; set; }

            [JsonProperty("experimentId")]
            public long ExperimentId { get; set; }

            [JsonProperty("goalEvent")]
            public GoalEvent GoalEvent { get; set; }
        }

        public partial class GoalEvent
        {
            [JsonProperty("category")]
            public string Category { get; set; }

            [JsonProperty("action")]
            public string Action { get; set; }
        }
    }
}
