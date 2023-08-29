using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Tokens.Options;
using Microsoft.Extensions.Configuration;

namespace BookShopAPI.Infrastructure.Helpers
{
    public static class AccessTokenOptionsHelper
    {
        public static AccessTokenOptions GetAccessTokenOptions()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("AccessTokenOptions").Get<AccessTokenOptions>();
        }
    }
}