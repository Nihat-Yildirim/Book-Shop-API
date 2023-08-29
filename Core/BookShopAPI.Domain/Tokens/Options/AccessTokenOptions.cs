namespace BookShopAPI.Domain.Tokens.Options
{
    public class AccessTokenOptions
    {
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public string? SecurityKey { get; set; }
        public int AccessTokenExpirationMinute { get; set; }
    }
}