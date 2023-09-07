namespace BookShopAPI.Domain.RequestParameters
{
    public record class Pagination
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}