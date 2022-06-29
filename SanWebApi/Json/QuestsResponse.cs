using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanWebApi.Json
{
    public class QuestsResponse
    {
        public QuestData[] data { get; set; }

        public class QuestData
        {
            public string id { get; set; }
            public string creatorPersonaId { get; set; }
            public string imageAssetId { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int timeLimit { get; set; }
            public int minScore { get; set; }
            public string completionRule { get; set; }
            public string state { get; set; }
            public object score { get; set; }
            public object time { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public Reward[] rewards { get; set; }
            public Image image { get; set; }
            public Objective[] objectives { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
            public Sizes sizes { get; set; }
        }

        public class Sizes
        {
            public Grid grid { get; set; }
        }

        public class Grid
        {
            public string url { get; set; }
            public int width { get; set; }
        }

        public class Reward
        {
            public int id { get; set; }
            public string type { get; set; }
            public int amount { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Objective
        {
            public string id { get; set; }
            public string creatorPersonaId { get; set; }
            public string handle { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int? timeLimit { get; set; }
            public object minScore { get; set; }
            public object requiredCount { get; set; }
            public int ordinal { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public string initialState { get; set; }
            public string questId { get; set; }
            public string playerPersonaId { get; set; }
            public string state { get; set; }
            public object time { get; set; }
            public object score { get; set; }
            public object count { get; set; }
        }
    }
}
