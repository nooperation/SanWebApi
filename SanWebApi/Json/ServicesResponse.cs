using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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

        public partial class DomainsClass
        {
            [JsonProperty("extraction")]
            public Extraction Extraction { get; set; }

            [JsonProperty("webapi")]
            public Webapi Webapi { get; set; }
        }

        public partial class Extraction
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public partial class Webapi
        {
            [JsonProperty("v2")]
            public Uri V2 { get; set; }
        }

        public partial class ServicesClass
        {
            [JsonProperty("asset-director")]
            public AssetDirector AssetDirector { get; set; }

            [JsonProperty("asset-director-ops")]
            public AssetDirector AssetDirectorOps { get; set; }

            [JsonProperty("asset-template")]
            public AssetTemplate AssetTemplate { get; set; }

            [JsonProperty("atlas")]
            public AssetDirector Atlas { get; set; }

            [JsonProperty("atlas-ops")]
            public AssetDirector AtlasOps { get; set; }

            [JsonProperty("grid-status")]
            public GridStatus GridStatus { get; set; }

            [JsonProperty("gridtool-api")]
            public GridtoolApi GridtoolApi { get; set; }

            [JsonProperty("inventory")]
            public GridtoolApi Inventory { get; set; }

            [JsonProperty("inventory-ops")]
            public GridtoolApi InventoryOps { get; set; }

            [JsonProperty("region-conductor")]
            public RegionConductor RegionConductor { get; set; }

            [JsonProperty("region-conductor-ops")]
            public RegionConductor RegionConductorOps { get; set; }

            [JsonProperty("sansar-account")]
            public GridtoolApi SansarAccount { get; set; }

            [JsonProperty("sansar-account-ops")]
            public GridtoolApi SansarAccountOps { get; set; }

            [JsonProperty("sansar-license-bundler")]
            public GridtoolApi SansarLicenseBundler { get; set; }

            [JsonProperty("sansar-personas")]
            public GridtoolApi SansarPersonas { get; set; }

            [JsonProperty("sansar-personas-ops")]
            public GridtoolApi SansarPersonasOps { get; set; }

            [JsonProperty("sansar-script-compiler")]
            public SansarScriptCompiler SansarScriptCompiler { get; set; }

            [JsonProperty("software-versions")]
            public GridStatus SoftwareVersions { get; set; }
        }

        public partial class AssetDirector
        {
            [JsonProperty("v3")]
            public Uri V3 { get; set; }
        }

        public partial class AssetTemplate
        {
            [JsonProperty("v1")]
            public string V1 { get; set; }
        }

        public partial class GridStatus
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public partial class GridtoolApi
        {
            [JsonProperty("v1")]
            public Uri V1 { get; set; }
        }

        public partial class RegionConductor
        {
            [JsonProperty("v6")]
            public Uri V6 { get; set; }
        }

        public partial class SansarScriptCompiler
        {
            [JsonProperty("v5")]
            public Uri V5 { get; set; }
        }


    }
}
