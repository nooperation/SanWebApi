using System;

namespace SanWebApi.Json
{
    public class EventsResponse
    {
        public Meta meta { get; set; }
        public EventData[] data { get; set; }

        public class Meta
        {
            public int page { get; set; }
            public int pages { get; set; }
            public int perPage { get; set; }
            public int total { get; set; }
        }

        public class EventData
        {
            public string[] access { get; set; }
            public string eventHandle { get; set; }
            public string eventKey { get; set; }
            public int featured { get; set; }
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int accessControls { get; set; }
            public string experienceId { get; set; }
            public string experienceName { get; set; }
            public string experienceSansarUri { get; set; }
            public string experienceAssetId { get; set; }
            public string experienceHandle { get; set; }
            public string experiencePersonaHandle { get; set; }
            public string hostPersonaName { get; set; }
            public string hostPersonaHandle { get; set; }
            public string hostPersonaId { get; set; }
            public string imageAssetId { get; set; }
            public object featuredAt { get; set; }
            public DateTime startsAt { get; set; }
            public DateTime endsAt { get; set; }
            public DateTime publishedAt { get; set; }
            public object[] banlist { get; set; }
            public object[] whitelist { get; set; }
            public Trending trending { get; set; }
            public Headcount headCount { get; set; }
            public string startToEndTimeString { get; set; }
            public string startToEndTimeStringLowerCase { get; set; }
            public string relativeStartEndString { get; set; }
            public string offset { get; set; }
            public string uri { get; set; }
            public string experienceCompatVersion { get; set; }
            public string handle { get; set; }
            public string key { get; set; }
            public Images images { get; set; }
            public bool savedToCalendar { get; set; }
            public int interestCount { get; set; }
        }

        public class Trending
        {
            public int _default { get; set; }
        }

        public class Headcount
        {
            public int _default { get; set; }
            public int _ { get; set; }
        }

        public class Images
        {
            public Experiencegrid experienceGrid { get; set; }
            public Experiencedetail experienceDetail { get; set; }
            public Experiencelarge experienceLarge { get; set; }
            public Experiencemax experienceMax { get; set; }
            public Grid grid { get; set; }
            public Detail detail { get; set; }
            public Large large { get; set; }
            public Max max { get; set; }
        }

        public class Experiencegrid
        {
            public string url { get; set; }
            public object png { get; set; }
            public int width { get; set; }
        }

        public class Experiencedetail
        {
            public string url { get; set; }
            public object png { get; set; }
            public int width { get; set; }
        }

        public class Experiencelarge
        {
            public string url { get; set; }
            public object png { get; set; }
            public int width { get; set; }
        }

        public class Experiencemax
        {
            public string url { get; set; }
            public object png { get; set; }
            public int width { get; set; }
        }

        public class Grid
        {
            public string url { get; set; }
            public string png { get; set; }
            public int width { get; set; }
        }

        public class Detail
        {
            public string url { get; set; }
            public string png { get; set; }
            public int width { get; set; }
        }

        public class Large
        {
            public string url { get; set; }
            public string png { get; set; }
            public int width { get; set; }
        }

        public class Max
        {
            public string url { get; set; }
            public string png { get; set; }
            public int width { get; set; }
        }
    }
}
