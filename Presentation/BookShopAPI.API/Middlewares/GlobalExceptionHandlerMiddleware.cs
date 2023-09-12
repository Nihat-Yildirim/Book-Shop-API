using BookShopAPI.Domain.Results.Concretes;
using Serilog.Context;
using System.Net;
using System.Text.Json;

namespace BookShopAPI.API.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<GlobalExceptionHandlerMiddleware> logger)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception, logger);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception, ILogger<GlobalExceptionHandlerMiddleware> logger)
        {
            var statusCode = HttpStatusCode.InternalServerError;

            var resultException = JsonSerializer.Serialize(new ExceptionResult
            {
                Title = "Unexpected Error Occurred",
                Errors = new()
                {
                    exception.Message.ToString()
                },
                StatusCode = statusCode
            });

            LogContext.PushProperty("ExceptionStackTrace", exception.StackTrace);
            LogContext.PushProperty("SimpleMessage", "Önemli Hata");
            LogContext.PushProperty("Exception",exception.Message);
            logger.LogCritical(exception.Message);

            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(resultException);
        }
    }
}