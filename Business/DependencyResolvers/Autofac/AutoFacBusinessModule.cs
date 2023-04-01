using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.Stroge;
using Business.Stroge.Local;
using Core.Utilities.Security.JWT;
using Core.Utilities.Stroge;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutoFacBusinessModule  : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<DealerManager>().As<IDealerService>().SingleInstance();
            builder.RegisterType<EfDealerDal>().As<IDealerDal>().SingleInstance();

            builder.RegisterType<StrogeManager>().As<IStrogeService>().SingleInstance();
            builder.RegisterType<LocalStroge>().As<IStroge>().SingleInstance(); 

            builder.RegisterType<EfCustomerAvatarDal>().As<ICustomerAvatarDal>().SingleInstance();
            builder.RegisterType<CustomerAvatarManager>().As<ICustomerAvatarService>().SingleInstance();
        }
    }
}