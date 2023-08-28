using BookShopAPI.Application.Mailing;
using BookShopAPI.Infrastructure.Mailing.MailKit;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailkitMailService>();
        }
    }
}