using BookShopAPI.Domain.Results.Abstracts;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class FailDataResponse<TData> : BaseDataResponse<TData>
        where TData : class, new()
    {
        public FailDataResponse(string message) : base(false, message, default)
        {
        }

        public FailDataResponse() : base(default,false)
        {
        }
    }
}