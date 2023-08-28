using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Infrastructure.Mailing.MailKit;
using BookShopAPI.Infrastructure.OtpAuthenticators;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailkitMailService>();

            services.AddScoped<IOtpAuthenticator, OtpNetAuthenticator>();
        }
    }
}