using BookShopAPI.API.Middlewares;

namespace BookShopAPI.API.Extensions
{
    public static class GlobalExceptionHandlerExtension
    {
        public static void AddGlobalExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<GlobalExceptionHandlerMiddleware>();
        }
    }
}