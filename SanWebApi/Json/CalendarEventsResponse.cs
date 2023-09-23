namespace SanWebApi.Json
{
    public class CalendarEventsResponse
    {
        public EventsResponse.Meta meta { get; set; }
        public CalendarEventData[] data { get; set; }

        public class CalendarEventData
        {
            public string personaId { get; set; }
            public string eventId { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public string status { get; set; }
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string experienceSansarUri { get; set; }
            public DateTime startsAt { get; set; }
            public DateTime endsAt { get; set; }
            public DateTime publishedAt { get; set; }
            public string experiencePersonaHandle { get; set; }
            public string experienceHandle { get; set; }
            public string experienceAssetId { get; set; }
            public string hostPersonaHandle { get; set; }
            public string hostPersonaName { get; set; }
            public object featuredAt { get; set; }
            public string experienceName { get; set; }
            public string experienceId { get; set; }
            public string imageAssetId { get; set; }
            public int accessControls { get; set; }
            public string hostPersonaId { get; set; }
            public string banlist { get; set; }
            public string whitelist { get; set; }
            public string startToEndTimeString { get; set; }
            public string startToEndTimeStringLowerCase { get; set; }
            public string relativeStartEndString { get; set; }
            public string offset { get; set; }
            public string uri { get; set; }
            public string experienceCompatVersion { get; set; }
            public string handle { get; set; }
            public string key { get; set; }
            public EventsResponse.Images images { get; set; }
            public EventsResponse.Headcount headCount { get; set; }
            public bool savedToCalendar { get; set; }
        }
    }
}
