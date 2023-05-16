using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging
{
    public interface ILoggerService
    {
        void LogDebug(LogDetail detail);
        void LogInfo(LogDetail logDetail);
        void LogWarning(LogDetailWithException logDetailWithException);
        void LogError(LogDetailWithException logDetailWithException);
        void LogFatal(LogDetailWithException logDetailWithException);
    }
}