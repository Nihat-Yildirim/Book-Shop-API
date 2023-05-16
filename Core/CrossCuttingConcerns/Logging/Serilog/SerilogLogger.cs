using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog.Context;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Serilog
{
    public class SerilogLogger : ILoggerService
    {
        private static Logger _logger;
        public SerilogLogger()
        {
        }

        public static void ConfigureLogger(Logger logger)
        {
            _logger = logger;
        }

        public void LogDebug(LogDetail logDetail)
        {
            LogContext.PushProperty("MethodName", logDetail.MethodName);
            LogContext.PushProperty("SimpleMessage", logDetail.SimpleMessage);

            _logger.Debug(logDetail.Message);
        }

        public void LogError(LogDetailWithException logDetailWithException)
        {
            LogContext.PushProperty("MethodName", logDetailWithException.MethodName);
            LogContext.PushProperty("SimpleMessage", logDetailWithException.SimpleMessage);
            LogContext.PushProperty("ExceptionStackTrace", logDetailWithException.ExceptionStackTrace);
            LogContext.PushProperty("Message", logDetailWithException.Message);

            _logger.Error(exception: logDetailWithException.Exception, messageTemplate: logDetailWithException.Message);
        }

        public void LogFatal(LogDetailWithException logDetailWithException)
        {
            LogContext.PushProperty("MethodName", logDetailWithException.MethodName);
            LogContext.PushProperty("SimpleMessage", logDetailWithException.SimpleMessage);
            LogContext.PushProperty("ExceptionStackTrace", logDetailWithException.ExceptionStackTrace);

            _logger.Fatal(exception: logDetailWithException.Exception, messageTemplate: logDetailWithException.Message);
        }

        public void LogInfo(LogDetail logDetail)
        {
            LogContext.PushProperty("MethodName", logDetail.MethodName);
            LogContext.PushProperty("SimpleMessage", logDetail.SimpleMessage);

            _logger.Information(logDetail.Message);
        }

        public void LogWarning(LogDetailWithException logDetailWithException)
        {
            LogContext.PushProperty("MethodName", logDetailWithException.MethodName);
            LogContext.PushProperty("SimpleMessage", logDetailWithException.SimpleMessage);
            LogContext.PushProperty("ExceptionStackTrace", logDetailWithException.ExceptionStackTrace);

            _logger.Warning(exception : logDetailWithException.Exception,messageTemplate : logDetailWithException.Message);
        }
    }
}