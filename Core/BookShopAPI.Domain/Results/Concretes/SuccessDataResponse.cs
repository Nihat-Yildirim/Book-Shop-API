using BookShopAPI.Domain.Results.Abstracts;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class SuccessDataResponse<TData> : BaseDataResponse<TData>
        where TData : class, new()
    {
        public SuccessDataResponse(TData data, string message) : base(data, true)
        {
        }

        public SuccessDataResponse(string message) : base(true, message, default)
        {
        }

        public SuccessDataResponse(TData data) : base(data, true)
        {
        }

        public SuccessDataResponse() : base(default, true)
        {
        }
    }
}