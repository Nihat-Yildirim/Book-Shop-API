using Microsoft.Extensions.Configuration;

namespace BookShopAPI.Persistence.Helpers
{
    public static class ConnectionStringHelper
    {
        public static string GetSqlServerConnectionString()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("SQLConnection");
        }

        public static string GetRedisConnectionString()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("RedisConnection");
        }
    }
}