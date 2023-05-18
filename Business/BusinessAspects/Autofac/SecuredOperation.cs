using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Logging;
using Core.Exceptions.Concrete;
using Core.Extensions;
using Core.Utilities.Helpers.MethodNameHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;
        private ILoggerService _loggerService;
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(",");
            _loggerService = ServiceTool.ServiceProvider.GetService<ILoggerService>();
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roles = _httpContextAccessor.HttpContext.User.ClaimRoles();

            foreach(var role in _roles)
            {
                if (roles.Contains(role))
                    return;
            }

            LogDetail logDetail = new();
            logDetail.Message = "Kullanıcı yetkisi yetersiz bu nedenle işlem gerçekleştirilemedi !";
            logDetail.SimpleMessage = "Yetkilendirme Logu";
            logDetail.MethodName = MethodNameTool.GetMethodName(invocation);
            _loggerService.LogInfo(logDetail);

            throw new SecuredOperationException("Kullanıcı Yetkisi Yetersiz !");
        }
    }
}