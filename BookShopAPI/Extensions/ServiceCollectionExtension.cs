using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Entities.MapperProfiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace BookShopAPI.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureAuthentication(this IServiceCollection services,TokenOptions tokenOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = tokenOptions.Issuer,
                    ValidAudience = tokenOptions.Audience,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                };
            });
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            List<Type> profiles = new List<Type>
            {
                typeof(FileProfile),
                typeof(UserAddressProfile),
                typeof(StoreProfile),
                typeof(UserProfile),
                typeof(CategoryProfile)
            };

            foreach(var profile in profiles)
                services.AddAutoMapper(profile);
        }
    }
}