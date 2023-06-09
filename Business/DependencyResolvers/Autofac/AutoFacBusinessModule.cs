﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Business.Stroge;
using Business.Stroge.Local;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Castle.DynamicProxy;
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

            builder.RegisterType<FileManager>().As<IFileService>().SingleInstance();
            builder.RegisterType<EfFileDal>().As<IFileDal>().SingleInstance();

            builder.RegisterType<StoreManager>().As<IStoreService>().SingleInstance();
            builder.RegisterType<EfStoreDal>().As<IStoreDal>().SingleInstance();

            builder.RegisterType<UserAddressManager>().As<IUserAddressService>().SingleInstance();
            builder.RegisterType<EfUserAddressDal>().As<IUserAddressDal>().SingleInstance();

            builder.RegisterType<UserPhoneNumberManager>().As<IUserPhoneNumberService>().SingleInstance();
            builder.RegisterType<EfUserPhoneNumberDal>().As<IUserPhoneNumberDal>().SingleInstance();

            builder.RegisterType<AuthorManager>().As<IAuthorService>().SingleInstance();
            builder.RegisterType<EfAuthorDal>().As<IAuthorDal>().SingleInstance();

            builder.RegisterType<PublisherManager>().As<IPublisherService>().SingleInstance();
            builder.RegisterType<EfPublisherDal>().As<IPublisherDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategorService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
            builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();

            builder.RegisterType<BookOfCategoryManager>().As<IBookOfCategoryService>().SingleInstance();
            builder.RegisterType<EfBookOfCategoryDal>().As<IBookOfCategoryDal>().SingleInstance();

            builder.RegisterType<BookPictureManager>().As<IBookPictureService>().SingleInstance();
            builder.RegisterType<EfBookPictureDal>().As<IBookPictureDal>().SingleInstance();

            builder.RegisterType<UserClaimManager>().As<IUserClaimService>().SingleInstance();  
            builder.RegisterType<EfUserClaimDal>().As<IUserClaimDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}