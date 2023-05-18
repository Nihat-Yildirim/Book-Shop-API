using Castle.DynamicProxy;
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
using System.Transactions;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        ILoggerService _loggerService;
        public TransactionScopeAspect()
        {
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
        }

        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (Exception exception)
                {
                    transactionScope.Dispose();

                    LogDetailWithException logDetailWithException = new();
                    logDetailWithException.Exception = exception;
                    logDetailWithException.Message = "Method çalışırken hata aldı bu nedenle işlemler geri alındı !";
                    logDetailWithException.MethodName = MethodNameTool.GetMethodName(invocation);
                    logDetailWithException.ExceptionStackTrace = exception.StackTrace;
                    logDetailWithException.SimpleMessage = "Transaction Logu";
                    _loggerService.LogWarning(logDetailWithException);

                    throw;
                }
            }
        }
    }
}