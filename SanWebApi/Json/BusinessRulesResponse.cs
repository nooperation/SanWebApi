using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class BusinessRulesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public List<object> Message { get; set; }

        [JsonProperty("codes")]
        public List<object> Codes { get; set; }

        [JsonProperty("payload")]
        public PayloadClass Payload { get; set; }

        public class Atlas
        {
            [JsonProperty("live_limit")]
            public int LiveLimit { get; set; }

            [JsonProperty("entry_limit")]
            public int EntryLimit { get; set; }
        }

        public class Levels
        {
            [JsonProperty("sansar_creator")]
            public SansarCreator SansarCreator { get; set; }

            [JsonProperty("sansar_creator_comp")]
            public SansarCreatorComp SansarCreatorComp { get; set; }

            [JsonProperty("sansar_free")]
            public SansarFree SansarFree { get; set; }

            [JsonProperty("sansar_open_beta_trial")]
            public SansarOpenBetaTrial SansarOpenBetaTrial { get; set; }

            [JsonProperty("sansar_professional")]
            public SansarProfessional SansarProfessional { get; set; }

            [JsonProperty("sansar_professional_comp")]
            public SansarProfessionalComp SansarProfessionalComp { get; set; }

            [JsonProperty("sansar_super_creator")]
            public SansarSuperCreator SansarSuperCreator { get; set; }

            [JsonProperty("sansar_super_creator_comp")]
            public SansarSuperCreatorComp SansarSuperCreatorComp { get; set; }

            [JsonProperty("sansar_unlimited")]
            public SansarUnlimited SansarUnlimited { get; set; }
        }

        public class PayloadClass
        {
            [JsonProperty("current_version")]
            public string CurrentVersion { get; set; }

            [JsonProperty("versions")]
            public Versions Versions { get; set; }
        }

        public class Promotions
        {
            [JsonProperty("trial")]
            public List<string> Trial { get; set; }

            [JsonProperty("discount")]
            public string Discount { get; set; }
        }

        public class SansarCreator
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarCreatorComp
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarFree
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarOpenBetaTrial
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarProfessional
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarProfessionalComp
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarSuperCreator
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarSuperCreatorComp
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public List<string> Support { get; set; }
        }

        public class SansarUnlimited
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
            public Promotions Promotions { get; set; }

            [JsonProperty("store")]
            public Store Store { get; set; }

            [JsonProperty("support")]
            public object Support { get; set; }
        }

        public class Store
        {
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        public class V1
        {
            [JsonProperty("level_order")]
            public List<string> LevelOrder { get; set; }

            [JsonProperty("levels")]
            public Levels Levels { get; set; }
        }

        public class Versions
        {
            [JsonProperty("v1")]
            public V1 V1 { get; set; }
        }
    }
}
