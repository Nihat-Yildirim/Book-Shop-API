namespace BookShopAPI.Domain.Results.Abstracts
{
    public class BaseDataResponse<TData> : BaseResponse
        where TData : class , new()
    {
        public BaseDataResponse(bool succes , string message , TData data) : base(succes , message)
        {
            Data = data;
        }

        public BaseDataResponse(TData data , bool success) : base(success)
        {
            Data = data;
        }

        public TData Data { get; }
    }
}