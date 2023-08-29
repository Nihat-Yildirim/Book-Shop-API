using BookShopAPI.Infrastructure.Filters;

namespace BookShopAPI.API.Extensions
{
    public static class ConfiguraValidationFilterExtension
    {
        public static void ConfigureValidationFilter(this IServiceCollection services)
        {
            services.AddMvc(options => options.Filters.Add(new ValidationFilter()));
        }
    }
}