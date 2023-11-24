using BookShopAPI.API.Middlewares;

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