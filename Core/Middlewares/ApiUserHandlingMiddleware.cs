using Microsoft.AspNetCore.Http;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Middlewares
{
    public class ApiUserHandlingMiddleware
    {
        RequestDelegate _next;

        public ApiUserHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string userName;

            if (context.User != null && context.User.Identity != null && context.User.Identity.IsAuthenticated)
                userName = context.User.Identity.Name;
            else
                userName = "Visitor";

            LogContext.PushProperty("UserName", userName);

            await _next(context);
        }
    }
}