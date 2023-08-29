using BookShopAPI.Domain.Tokens.Options;
using Microsoft.Extensions.Configuration;

namespace BookShopAPI.Infrastructure.Helpers
{
    public static class RefreshTokenOptionsHelper
    {
        public static RefreshTokenOptions GetRefreshTokenOptions()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("RefreshTokenOptions").Get<RefreshTokenOptions>();
        }
    }
}