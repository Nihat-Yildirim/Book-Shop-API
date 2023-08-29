using BookShopAPI.Domain.Results.Abstracts;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class FailNoDataResponse : BaseResponse
    {
        public FailNoDataResponse(string message) : base(false,message)
        {
        }

        public FailNoDataResponse() : base(false)
        {
        }
    }
}