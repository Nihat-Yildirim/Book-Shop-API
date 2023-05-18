using Core.CrossCuttingConcerns.Logging;
using Core.Exceptions.Abstract;
using Core.Utilities.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Middlewares
{
    public class GlobalExceptionHandlingMiddleware
    {
        RequestDelegate _next;
        ILoggerService _loggerService;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ExceptionBase exception)
            {
                await HandleExceptionAsync(context, exception.Message, exception.StackTrace, exception.Title, exception.StatusCode);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception.Message, exception.StackTrace);
                
                LogDetailWithException logDetailWithException = new();
                logDetailWithException.Exception = exception;
                logDetailWithException.ExceptionStackTrace = exception.StackTrace;
                logDetailWithException.SimpleMessage = "Hata Logu !";
                logDetailWithException.MethodName = exception.Message;
                _loggerService.LogError(logDetailWithException);
            }
        }

        public Task HandleExceptionAsync(HttpContext context, string message, string? stackTrace,
            string title = "Beklenmeyen Hata Oluştu", HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError)
        {
            HttpStatusCode httpStatus = httpStatusCode;

            if (httpStatusCode == default)
                httpStatus = HttpStatusCode.InternalServerError;

            var resultException = JsonSerializer.Serialize(new
            {
                Error = message,
                StatusCode = (int)httpStatus,
                Title = title
            });

            context.Response.StatusCode = (int)httpStatus;
            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(resultException);
        }
    }
}