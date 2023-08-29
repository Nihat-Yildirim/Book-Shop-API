namespace BookShopAPI.Domain.Results.Abstracts
{
    public abstract class BaseResponse
    {
        public BaseResponse(bool success, string message) : this(success)
        {
            Message = message;
        }

        public BaseResponse(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string? Message { get; set; }
    }
}