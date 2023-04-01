using Core.Exceptions.Abstract;
using Microsoft.AspNetCore.Http;
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

        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ExceptionBase exception)
            {
                await HandleExceptionAsync(context, exception.Message, exception.StackTrace,exception.StatusCode);
            }
            catch(Exception exception) 
            {
                await HandleExceptionAsync(context,exception.Message, exception.StackTrace);
            }
        }

        public Task HandleExceptionAsync(HttpContext context,string message, string? stackTrace,HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError)
        {
            HttpStatusCode httpStatus = httpStatusCode;

            if (httpStatusCode == default)
                httpStatus = HttpStatusCode.InternalServerError;

            var resultException = JsonSerializer.Serialize(new 
            { 
                Error = message,
                StatusCode = (int)httpStatus,
                Title = "Beklenmeyen Hata Oluştu"
            });

            context.Response.StatusCode = (int)httpStatus;
            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(resultException);
        }
    }
}