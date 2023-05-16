using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.MethodNameHelper
{
    public static class MethodNameTool
    {
        public static string GetMethodName(IInvocation invocation)
        {
            return String.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}()");
        }
    }
}
