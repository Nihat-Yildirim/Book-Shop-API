using BookShopAPI.Domain.Results.Concretes;
using BookShopAPI.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BookShopAPI.Infrastructure.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class AuthenticationFilter : Attribute, IAuthorizationFilter
    {
        private readonly List<string> _roles;

        public AuthenticationFilter(string roles)
        {
            _roles = roles.Split("/").ToList();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var claims = context.HttpContext.User.GetRoles();
            bool isAuthorize = false;

            claims.ForEach(claim =>
            {
                _roles.ForEach(role =>
                {
                    if (role.ToUpper() == claim.ToUpper())
                        isAuthorize = true;
                });
            });

            if (!isAuthorize)
            {
                ExceptionResult exceptionResult = new()
                {
                    Errors = new() { "Authorization Denied !" },
                    StatusCode = HttpStatusCode.BadRequest,
                    Title = "Authorization Exception"
                };

                context.Result = new BadRequestObjectResult(exceptionResult);
            }
        }
    }
}