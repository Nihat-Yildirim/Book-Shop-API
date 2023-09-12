using BookShopAPI.Application.Helpers.Encryption;
using BookShopAPI.Domain.Tokens.Options;
using BookShopAPI.Infrastructure.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BookShopAPI.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureAuthentication(this IServiceCollection services, AccessTokenOptions accessTokenOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = accessTokenOptions.Issuer,
                        ValidAudience = accessTokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(accessTokenOptions.SecurityKey),
                    };
                });
        }

        public static void ConfigureValidationFilter(this IServiceCollection services)
        {
            services.AddMvc(options => options.Filters.Add(new ValidationFilter()));
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }
    }
}