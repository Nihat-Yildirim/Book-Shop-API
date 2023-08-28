using BookShopAPI.Domain.Mailing;
using Microsoft.Extensions.Configuration;

namespace BookShopAPI.Infrastructure.Helpers
{
    public static class MailSettingsHelper
    {
        public static MailSettings GetMailSettings()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("MailSettings").Get<MailSettings>();
        }
    }
}