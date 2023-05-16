using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities.Helpers.MethodNameHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;
        private ILoggerService _loggerService;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            LogDetailWithException logDetailWithException = new();
            logDetailWithException.MethodName = MethodNameTool.GetMethodName(invocation);
            logDetailWithException.SimpleMessage = "Performans Logu";

            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                logDetailWithException.Message = $"Geçen Süre : {_stopwatch.Elapsed.TotalSeconds} > Sınırlanan Süre : {_interval}";
                _loggerService.LogWarning(logDetailWithException);
            }
            else
            {
                logDetailWithException.Message = $"Geçen Süre : {_stopwatch.Elapsed.TotalSeconds} < Sınırlanan Süre : {_interval}";
                _loggerService.LogInfo((LogDetail)logDetailWithException);
            }
            
            _stopwatch.Stop();
        }
    }
}