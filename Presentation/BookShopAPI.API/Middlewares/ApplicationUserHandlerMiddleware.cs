using BookShopAPI.Infrastructure.Extensions;
using Serilog.Context;

namespace BookShopAPI.API.Middlewares
{
    public class ApplicationUserHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ApplicationUserHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var name = context.User.GetName();

            if (name == null)
                LogContext.PushProperty("UserName", "Visitor");

            if(name != null)
                LogContext.PushProperty("UserName", name);

            await _next(context);
        }
    }
}