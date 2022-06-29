using System;

namespace SanWebApi.Json
{

    public class AddReviewResponse
    {
        public Data data { get; set; }
        public Included[] included { get; set; }

        public class Data
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Relationships relationships { get; set; }
        }

        public class Attributes
        {
            public string reviewSummaryId { get; set; }
            public string personaId { get; set; }
            public object content { get; set; }
            public int rating { get; set; }
            public DateTime createdAt { get; set; }
        }

        public class Relationships
        {
            public Reviewsummary reviewSummary { get; set; }
        }

        public class Reviewsummary
        {
            public ReviewSummaryData data { get; set; }

            public class ReviewSummaryData
            {
                public string id { get; set; }
                public string type { get; set; }
            }
        }

        public class Included
        {
            public string type { get; set; }
            public string id { get; set; }
            public IncludedAttributes attributes { get; set; }
            public IncludedRelationships relationships { get; set; }
        }

        public class IncludedAttributes
        {
            public string type { get; set; }
            public int totalRating { get; set; }
            public int reviewCount { get; set; }
            public int averageRating { get; set; }
        }

        public class IncludedRelationships
        {
        }
    }
}
