using Newtonsoft.Json;

namespace SanWebApi.Json
{
    public class ServicesResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domains")]
        public DomainsClass Domains { get; set; }

        [JsonProperty("services")]
        public ServicesClass Services { get; set; }

        public class AssetDirector
        {
            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public class AssetDirectorOps
        {
            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public class AssetTemplate
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class Atlas
        {
            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public class AtlasOps
        {
            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public class DomainsClass
        {
            [JsonProperty("extraction")]
            public Extraction Extraction { get; set; }

            [JsonProperty("webapi")]
            public Webapi Webapi { get; set; }
        }

        public class Extraction
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public class GridStatus
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class GridtoolApi
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class Inventory
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class InventoryOps
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class RegionConductor
        {
            [JsonProperty("v6")]
            public Uri V6 { get; set; }
        }

        public class RegionConductorOps
        {
            [JsonProperty("v6")]
            public Uri V6 { get; set; }
        }

        public class SansarAccount
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class SansarAccountOps
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class SansarLicenseBundler
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class SansarPersonas
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class SansarPersonasOps
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class SansarScriptCompiler
        {
            [JsonProperty("v5")]
            public Uri V5 { get; set; }
        }

        public class ServicesClass
        {
            [JsonProperty("asset-director")]
            public AssetDirector AssetDirector { get; set; }

            [JsonProperty("asset-director-ops")]
            public AssetDirectorOps AssetDirectorOps { get; set; }

            [JsonProperty("asset-template")]
            public AssetTemplate AssetTemplate { get; set; }

            [JsonProperty("atlas")]
            public Atlas Atlas { get; set; }

            [JsonProperty("atlas-ops")]
            public AtlasOps AtlasOps { get; set; }

            [JsonProperty("grid-status")]
            public GridStatus GridStatus { get; set; }

            [JsonProperty("gridtool-api")]
            public GridtoolApi GridtoolApi { get; set; }

            [JsonProperty("inventory")]
            public Inventory Inventory { get; set; }

            [JsonProperty("inventory-ops")]
            public InventoryOps InventoryOps { get; set; }

            [JsonProperty("region-conductor")]
            public RegionConductor RegionConductor { get; set; }

            [JsonProperty("region-conductor-ops")]
            public RegionConductorOps RegionConductorOps { get; set; }

            [JsonProperty("sansar-account")]
            public SansarAccount SansarAccount { get; set; }

            [JsonProperty("sansar-account-ops")]
            public SansarAccountOps SansarAccountOps { get; set; }

            [JsonProperty("sansar-license-bundler")]
            public SansarLicenseBundler SansarLicenseBundler { get; set; }

            [JsonProperty("sansar-personas")]
            public SansarPersonas SansarPersonas { get; set; }

            [JsonProperty("sansar-personas-ops")]
            public SansarPersonasOps SansarPersonasOps { get; set; }

            [JsonProperty("sansar-script-compiler")]
            public SansarScriptCompiler SansarScriptCompiler { get; set; }

            [JsonProperty("software-versions")]
            public SoftwareVersions SoftwareVersions { get; set; }
        }

        public class SoftwareVersions
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public class Webapi
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }


    }
}
