namespace SanWebApi.Json
{

    public class GetReviewsResponse
    {
        public Meta meta { get; set; }
        public AddReviewResponse.Data[] data { get; set; }
        public AddReviewResponse.Included[] included { get; set; }
    }

    public class Meta
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perPage { get; set; }
        public int total { get; set; }
    }
}
