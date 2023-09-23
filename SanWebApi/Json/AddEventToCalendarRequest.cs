namespace SanWebApi.Json
{
    public class AddEventToCalendarRequest
    {
        public Data data { get; set; }

        public AddEventToCalendarRequest(string eventId)
        {
            data = new Data() { eventId = eventId };
        }

        public class Data
        {
            public string eventId { get; set; }
        }
    }
}
