using System.Net;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class ExceptionResult
    {
        public string? Title { get; set; }
        public List<string>? Errors { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}