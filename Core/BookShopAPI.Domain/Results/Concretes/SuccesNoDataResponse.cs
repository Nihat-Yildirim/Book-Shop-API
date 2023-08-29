using BookShopAPI.Domain.Results.Abstracts;

namespace BookShopAPI.Domain.Results.Concretes
{
    public class SuccesNoDataResponse : BaseResponse
    {
        public SuccesNoDataResponse(string message) : base(true, message)
        {
        }

        public SuccesNoDataResponse() : base(true)
        {
        }
    }
}