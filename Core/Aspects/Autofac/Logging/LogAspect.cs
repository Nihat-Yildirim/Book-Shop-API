using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Logging
{
    public class LogAspect : MethodInterception
    {
        ILoggerService _loggerService;
        public LogAspect()
        {
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            LogDetail logDetail = new();
            logDetail.Message = "Metod çalışmaya başladı !";
            logDetail.MethodName = String.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}()");
            logDetail.SimpleMessage = "Bilgilendirme Logu";

            _loggerService.LogInfo(logDetail);
        }

        protected override void OnException(IInvocation invocation, Exception exception)
        {
            LogDetailWithException logDetailWithException = new();
            logDetailWithException.Message = "Metod çalışırken bir hata oluştu !";
            logDetailWithException.MethodName = String.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}()");
            logDetailWithException.Exception = exception;
            logDetailWithException.ExceptionStackTrace = exception.StackTrace;
            logDetailWithException.SimpleMessage = "Hata Logu";

            _loggerService.LogError(logDetailWithException);
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            LogDetail logDetail = new();
            logDetail.Message = "Metod işlemleri başarıyla gerçekleştirdi !";
            logDetail.MethodName = String.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}()");
            logDetail.SimpleMessage = "Bilgilendirme Logu";

            _loggerService.LogInfo(logDetail);
        }
    }
}