using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Infrastructure.Mailing.MailKit;
using BookShopAPI.Infrastructure.OtpAuthenticators;
using BookShopAPI.Infrastructure.Tokens;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailkitMailService>();

            services.AddScoped<IOtpAuthenticator, OtpNetAuthenticator>();

            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
        }
    }
}