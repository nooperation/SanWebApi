using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class BusinessRulesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public object[] Message { get; set; }

        [JsonProperty("codes")]
        public object[] Codes { get; set; }

        [JsonProperty("payload")]
        public PayloadClass Payload { get; set; }

        public partial class PayloadClass
        {
            [JsonProperty("current_version")]
            public string CurrentVersion { get; set; }

            [JsonProperty("versions")]
            public Versions Versions { get; set; }
        }

        public partial class Versions
        {
            [JsonProperty("v1")]
            public V1 V1 { get; set; }
        }

        public partial class V1
        {
            [JsonProperty("level_order")]
            public string[] LevelOrder { get; set; }

            [JsonProperty("levels")]
            public Levels Levels { get; set; }
        }

        public partial class Levels
        {
            [JsonProperty("sansar_creator")]
            public Sansar SansarCreator { get; set; }

            [JsonProperty("sansar_creator_comp")]
            public Sansar SansarCreatorComp { get; set; }

            [JsonProperty("sansar_free")]
            public Sansar SansarFree { get; set; }

            [JsonProperty("sansar_open_beta_trial")]
            public Sansar SansarOpenBetaTrial { get; set; }

            [JsonProperty("sansar_professional")]
            public Sansar SansarProfessional { get; set; }

            [JsonProperty("sansar_professional_comp")]
            public Sansar SansarProfessionalComp { get; set; }

            [JsonProperty("sansar_super_creator")]
            public Sansar SansarSuperCreator { get; set; }

            [JsonProperty("sansar_super_creator_comp")]
            public Sansar SansarSuperCreatorComp { get; set; }

            [JsonProperty("sansar_unlimited")]
            public SansarUnlimited SansarUnlimited { get; set; }
        }

        public partial class Sansar
        {
            [JsonProperty("public")]
            public bool Public { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("atlas")]
            public Atlas Atlas { get; set; }

            [JsonProperty("promotions")]
            public SansarCreatorPromotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public string[] Support { get; set; }
        }

        public partial class Atlas
        {
            [JsonProperty("live_limit")]
            public long LiveLimit { get; set; }

            [JsonProperty("entry_limit")]
            public long EntryLimit { get; set; }
        }

        public partial class SansarCreatorPromotions
        {
            [JsonProperty("trial")]
            public string[] Trial { get; set; }

            [JsonProperty("discount")]
            public string Discount { get; set; }
        }

        public partial class Store
        {
            [JsonProperty("limit")]
            public long Limit { get; set; }
        }

        public partial class SansarUnlimited
        {
            [JsonProperty("public")]
            public bool Public { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("atlas")]
            public Atlas Atlas { get; set; }

            [JsonProperty("promotions")]
            public SansarUnlimitedPromotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public object Support { get; set; }
        }

        public partial class SansarUnlimitedPromotions
        {
            [JsonProperty("trial")]
            public object Trial { get; set; }

            [JsonProperty("discount")]
            public string Discount { get; set; }
        }
    }
}
