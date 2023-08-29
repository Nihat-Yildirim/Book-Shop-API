namespace BookShopAPI.Domain.Tokens
{
    public abstract class BaseToken
    {
        public string? Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}