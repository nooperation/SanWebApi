using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanWebApi.Json
{
    public class ClientConfigResponse
    {
        [JsonProperty("config")]
        public ConfigClass Config { get; set; }

        [JsonProperty("capabilityMapping")]
        public CapabilityMappingClass CapabilityMapping { get; set; }

        [JsonProperty("exmox")]
        public ExmoxClass Exmox { get; set; }

        [JsonProperty("flags")]
        public FlagsClass Flags { get; set; }

        public class CapabilityMappingClass
        {
            [JsonProperty("animated")]
            public string Animated { get; set; }

            [JsonProperty("attachment-nonrigged")]
            public string AttachmentNonrigged { get; set; }

            [JsonProperty("attachment-bracelet")]
            public string AttachmentBracelet { get; set; }

            [JsonProperty("attachment-ears")]
            public string AttachmentEars { get; set; }

            [JsonProperty("attachment-glasses")]
            public string AttachmentGlasses { get; set; }

            [JsonProperty("attachment-necklace")]
            public string AttachmentNecklace { get; set; }

            [JsonProperty("attachment-rigged")]
            public string AttachmentRigged { get; set; }

            [JsonProperty("attachment-ring")]
            public string AttachmentRing { get; set; }

            [JsonProperty("animation")]
            public string Animation { get; set; }

            [JsonProperty("avatar")]
            public string Avatar { get; set; }

            [JsonProperty("hair")]
            public string Hair { get; set; }

            [JsonProperty("md")]
            public string Md { get; set; }

            [JsonProperty("female")]
            public string Female { get; set; }

            [JsonProperty("male")]
            public string Male { get; set; }
        }

        public class ConfigClass
        {
            [JsonProperty("ga")]
            public Ga Ga { get; set; }

            [JsonProperty("js")]
            public Js Js { get; set; }

            [JsonProperty("links")]
            public Links Links { get; set; }
        }

        public class Ga
        {
            [JsonProperty("accountId")]
            public string AccountId { get; set; }
        }

        public class Js
        {
            [JsonProperty("allow-twitch-mature-stream")]
            public string AllowTwitchMatureStream { get; set; }
        }

        public class Links
        {
            [JsonProperty("avatar2-blog")]
            public Uri Avatar2Blog { get; set; }

            [JsonProperty("kb-audio-materials")]
            public Uri KbAudioMaterials { get; set; }

            [JsonProperty("kb-creating-scenes")]
            public Uri KbCreatingScenes { get; set; }

            [JsonProperty("kb-geometry-standardization")]
            public Uri KbGeometryStandardization { get; set; }

            [JsonProperty("kb-global-illumination")]
            public Uri KbGlobalIllumination { get; set; }

            [JsonProperty("kb-uploading-items")]
            public Uri KbUploadingItems { get; set; }

            [JsonProperty("store-dashboard")]
            public Uri StoreDashboard { get; set; }

            [JsonProperty("user-snapshots-template")]
            public string UserSnapshotsTemplate { get; set; }

            [JsonProperty("user-experiences-template")]
            public string UserExperiencesTemplate { get; set; }

            [JsonProperty("quest-rewards")]
            public Uri QuestRewards { get; set; }
        }

        public class ExmoxClass
        {
            [JsonProperty("campaign_id")]
            public string CampaignId { get; set; }

            [JsonProperty("token")]
            public string Token { get; set; }
        }

        public class FlagsClass
        {
            [JsonProperty("optimizeRegPath")]
            public OptimizeRegPath OptimizeRegPath { get; set; }

            [JsonProperty("optimizeOnboarding")]
            public OptimizeOnboarding OptimizeOnboarding { get; set; }
        }

        public class OptimizeOnboarding
        {
            [JsonProperty("enabled")]
            public bool Enabled { get; set; }

            [JsonProperty("experimentId")]
            public string ExperimentId { get; set; }

            [JsonProperty("variants")]
            public OptimizeOnboardingVariants Variants { get; set; }

            [JsonProperty("goalEvent")]
            public GoalEvent GoalEvent { get; set; }
        }

        public class GoalEvent
        {
            [JsonProperty("category")]
            public string Category { get; set; }

            [JsonProperty("action")]
            public string Action { get; set; }
        }

        public class OptimizeOnboardingVariants
        {
            [JsonProperty("downloadOnly")]
            public DownloadOnly DownloadOnly { get; set; }

            [JsonProperty("downloadWithOnboarding")]
            public DownloadOnly DownloadWithOnboarding { get; set; }
        }

        public class DownloadOnly
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("distribution")]
            public long Distribution { get; set; }
        }

        public class OptimizeRegPath
        {
            [JsonProperty("enabled")]
            public bool Enabled { get; set; }

            [JsonProperty("experimentId")]
            public string ExperimentId { get; set; }

            [JsonProperty("variants")]
            public OptimizeRegPathVariants Variants { get; set; }

            [JsonProperty("goalEvent")]
            public GoalEvent GoalEvent { get; set; }
        }

        public class OptimizeRegPathVariants
        {
            [JsonProperty("webFirst")]
            public DownloadOnly WebFirst { get; set; }

            [JsonProperty("downloadFirst")]
            public DownloadOnly DownloadFirst { get; set; }
        }
    }
}
