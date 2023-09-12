using BookShopAPI.API.Middlewares;
using Serilog.Core;

namespace BookShopAPI.API.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void AddGlobalExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<GlobalExceptionHandlerMiddleware>();
        }

        public static void AddApplicationUserHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ApplicationUserHandlerMiddleware>();
        }
    }
}