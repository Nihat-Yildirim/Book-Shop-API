using BookShopAPI.Application.Helpers.Encryption;
using BookShopAPI.Domain.Tokens.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace BookShopAPI.API.Extensions
{
    public static class ConfigureAuthenticationExtension
    {
        public static void ConfigureAuthentication(this IServiceCollection services, AccessTokenOptions acccessTokenOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = acccessTokenOptions.Issuer,
                        ValidAudience = acccessTokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(acccessTokenOptions.SecurityKey),
                    };
                });
        }
    }
}