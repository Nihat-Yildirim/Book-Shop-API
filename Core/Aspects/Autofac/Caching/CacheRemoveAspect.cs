using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities.Helpers.MethodNameHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;
        private ILoggerService _loggerService;
        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            LogDetail logDetail = new();
            logDetail.Message = "Cacheden değerler silindi !";
            logDetail.MethodName = MethodNameTool.GetMethodName(invocation);
            logDetail.SimpleMessage = "Cache Logu";

            _loggerService.LogInfo(logDetail);
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}