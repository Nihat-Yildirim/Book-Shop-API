using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BookShopAPI.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Where(state => state.Value.Errors.Any())
                    .ToDictionary(errors => errors.Key, errors => errors.Value.Errors.Select(error => error.ErrorMessage))
                    .ToArray();

                context.Result = new BadRequestObjectResult(new
                {
                    Title = "Validasyon Hatası",
                    Errors = errors,
                    StatusCode = HttpStatusCode.BadRequest
                });

                return;
            }

            await next();
        }
    }
}