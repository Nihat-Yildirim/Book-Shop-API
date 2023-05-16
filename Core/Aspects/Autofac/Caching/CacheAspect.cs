using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities.Helpers.MethodNameHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using FluentValidation.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;
        private ILoggerService _loggerService;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
        }

        public override void Intercept(IInvocation invocation)
        {
            LogDetail logDetail = new();
            logDetail.MethodName = MethodNameTool.GetMethodName(invocation);
            logDetail.SimpleMessage = "Cache Logu";

            var methodName = MethodNameTool.GetMethodName(invocation);
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({String.Join(",", arguments.Select(a => a?.ToString() ?? "<null>"))})";

            if (_cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = _cacheManager.Get(key);
                logDetail.Message = "Metod cache'den çalıştı !";
                _loggerService.LogInfo(logDetail);
                
                return;
            }

            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);

            logDetail.Message = "Metodun döndüğü değerler cachelendi !";
            _loggerService.LogInfo(logDetail);
        }
    }
}