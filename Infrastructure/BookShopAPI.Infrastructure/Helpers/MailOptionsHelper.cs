using BookShopAPI.Domain.Mailing;
using Microsoft.Extensions.Configuration;

namespace BookShopAPI.Infrastructure.Helpers
{
    public static class MailOptionsHelper
    {
        public static MailOptions GetMailOptions()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("MailOptions").Get<MailOptions>();
        }
    }
}