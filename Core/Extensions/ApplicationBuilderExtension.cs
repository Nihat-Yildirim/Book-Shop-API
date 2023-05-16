using Core.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder AddGlobalExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlobalExceptionHandlingMiddleware>();
        }

        public static void AddApiUserHandlingMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ApiUserHandlingMiddleware>();
        }
    }
}
