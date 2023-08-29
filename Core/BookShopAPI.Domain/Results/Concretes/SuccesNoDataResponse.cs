using BookShopAPI.Domain.Results.Abstracts;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class SuccesNoDataResponse : BaseResponse
    {
        public SuccesNoDataResponse(string message) : base(false, message)
        {
        }

        public SuccesNoDataResponse() : base(false)
        {
        }
    }
}