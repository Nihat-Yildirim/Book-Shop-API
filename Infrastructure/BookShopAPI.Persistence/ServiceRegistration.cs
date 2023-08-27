using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BookShopDbContext>(options => options.UseSqlServer(ConnectionStringHelper.GetSqlServerConnectionString()));
        }
    }
}