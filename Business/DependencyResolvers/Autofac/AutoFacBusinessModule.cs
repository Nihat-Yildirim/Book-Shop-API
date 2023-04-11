using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.Stroge;
using Business.Stroge.Local;
using Core.Utilities.Security.JWT;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<DealerManager>().As<IDealerService>().SingleInstance();
            builder.RegisterType<EfDealerDal>().As<IDealerDal>().SingleInstance();

            builder.RegisterType<StorageManager>().As<IStorageService>().SingleInstance();
            builder.RegisterType<LocalStorage>().As<IStorage>().SingleInstance(); 

            builder.RegisterType<EfCustomerAvatarDal>().As<ICustomerAvatarDal>().SingleInstance();
            builder.RegisterType<CustomerAvatarManager>().As<ICustomerAvatarService>().SingleInstance();

            builder.RegisterType<FileManager>().As<IFileService>().SingleInstance();
            builder.RegisterType<EfFileDal>().As<IFileDal>().SingleInstance();

            builder.RegisterType<StoreManager>().As<IStoreService>().SingleInstance();
            builder.RegisterType<EfStoreDal>().As<IStoreDal>().SingleInstance();

            builder.RegisterType<UserAddressManager>().As<IUserAddressService>().SingleInstance();
            builder.RegisterType<EfUserAddressDal>().As<IUserAddressDal>().SingleInstance();

            builder.RegisterType<UserPhoneNumberManager>().As<IUserPhoneNumberService>().SingleInstance();
            builder.RegisterType<EfUserPhoneNumberDal>().As<IUserPhoneNumberDal>().SingleInstance();
        }
    }
}