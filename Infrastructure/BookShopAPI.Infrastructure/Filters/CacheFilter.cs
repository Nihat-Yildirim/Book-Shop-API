using BookShopAPI.Application.Cache;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Infrastructure.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheFilter : Attribute, IAsyncActionFilter, IAsyncResultFilter
    {
        private readonly double _obsoluteTimeHour;
        private readonly double _slidingTimeHour;
        private string cacheKey;

        public CacheFilter(double obsoluteTimeHour, double slidingTimeHour)
        {
            if (obsoluteTimeHour == 0)
                throw new Exception("Obsolute Time Not Equal 0 Hour");

            _obsoluteTimeHour = obsoluteTimeHour;
            _slidingTimeHour = slidingTimeHour;
        }

        //Metod çalışmadan önce (cache'de varsa getirecek)
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var cacheService = context.HttpContext.RequestServices.GetService<ICacheService>();

            var controllerName = context.Controller.ToString();
            controllerName = controllerName?.Remove(0, controllerName.LastIndexOf(".") + 1);

            var methodName = context.HttpContext.Request.Path.ToString();
            methodName = methodName.Remove(0, methodName.LastIndexOf("/") + 1);

            cacheKey = $"{controllerName}.{methodName}.Params=";
            var parameters = context.ActionArguments;

            if(parameters != null && parameters.Count == 1)
            {
                var requestParams = parameters?.Values?.FirstOrDefault()?
                                    .GetType()
                                    .GetProperties()
                                    .Select(x => new { 
                                        Name = x.Name,
                                        Value = x.GetValue(parameters.Values.FirstOrDefault())
                                    }).ToList();

                if (requestParams?.Count == 0)
                    cacheKey += "Null";

                foreach (var requestParam in requestParams)
                        cacheKey += requestParam.Name + ":" + requestParam.Value;
            }

            if(parameters != null && parameters.Count > 1)
            {
                for(int i = 0; i< parameters.Count; i++)
                {
                    var requestParam = parameters.ToList()[i];

                    if (!requestParam.Value.GetType().IsArray)
                        cacheKey += requestParam.Key + ":" + requestParam.Value;

                    if (requestParam.Value.GetType().IsArray)
                    {
                        int elementIndex = 0;
                        cacheKey += requestParam.Key + ":[";
                        var values = requestParam.Value as Array;
                        foreach (var value in values)
                        {
                            elementIndex++;
                            cacheKey += value + ",";
                            if (values.Length == elementIndex)
                                cacheKey += "]";
                        }
                    }

                    cacheKey += ",";
                }
            }

            var jsonCacheValue = await cacheService.TryGetJsonValue(cacheKey);
            if(jsonCacheValue != null)
            {
                context.HttpContext.Response.ContentType = "application/json";
                await context.HttpContext.Response.WriteAsync(jsonCacheValue);
                return;
            }

            await next();
        }

        //Metod çalıştıktan sonra (cache'e eklenecek)
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();

            var objResult = context.Result as ObjectResult;
            if (objResult != null && objResult.Value != null)
            {
                var cacheService = context.HttpContext.RequestServices.GetService<ICacheService>();
                await cacheService.CreateEntryAsync(cacheKey, objResult.Value,_obsoluteTimeHour,_slidingTimeHour);
            }
        }
    }
}