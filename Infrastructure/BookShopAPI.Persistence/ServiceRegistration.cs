﻿using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.Repositories.ClaimRepositories;
using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.OtpRecoveryCodeRepositories;
using BookShopAPI.Application.Repositories.PhoneNumberRepositories;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.Repositories.RefreshTokenRepositories;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.AddressRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.AuthorRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.BasketItemRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.BasketRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.BookPictureRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.BookRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.CategoryRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.ClaimRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.FileRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.OtpRecoveryCodeRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.PhoneNumberRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.PublisherRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.RefreshTokenRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.UserClaimRepositories;
using BookShopAPI.Persistence.EntityFramework.Repositories.UserRepositories;
using BookShopAPI.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookShopAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BookShopDbContext>(options => options.UseSqlServer(ConnectionStringHelper.GetSqlServerConnectionString()));

            services.AddScoped<IAddressReadRepository, AddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, AddressWriteRepository>();

            services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
            services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();

            services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
            services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();

            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();

            services.AddScoped<IBookPictureReadRepository, BookPictureReadRepository>();
            services.AddScoped<IBookPictureWriteRepository, BookPictureWriteRepository>();

            services.AddScoped<IBookReadRepository, BookReadRepository>();
            services.AddScoped<IBookWriteRepository, BookWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<IClaimReadRepository, ClaimReadRepository>();
            services.AddScoped<IClaimWriteRepository, ClaimWriteRepository>();

            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();

            services.AddScoped<IMailAuthenticationReadRepository, MailAuthenticationReadRepository>();
            services.AddScoped<IMailAuthenticationWriteRepository, MailAuthenticationWriteRepository>();

            services.AddScoped<IOtpAuthenticationReadRepository, OtpAuthenticationReadRepository>();
            services.AddScoped<IOtpAuthenticationWriteRepository, OtpAuthenticationWriteRepository>();

            services.AddScoped<IOtpRecoveryCodeReadRepository, OtpRecoveryCodeReadRepository>();
            services.AddScoped<IOtpRecoveryCodeWriteRepository, OtpRecoveryCodeWriteRepository>();

            services.AddScoped<IPhoneNumberReadRepository, PhoneNumberReadRepository>();
            services.AddScoped<IPhoneNumberWriteRepository, PhoneNumberWriteRepository>();

            services.AddScoped<IPublisherReadRepository, PublisherReadRepository>();
            services.AddScoped<IPublisherWriteRepository, PublisherWriteRepository>();

            services.AddScoped<IRefreshTokenReadRepository, RefreshTokenReadRepository>();
            services.AddScoped<IRefreshTokenWriteRepository, RefreshTokenWriteRepository>();

            services.AddScoped<IUserClaimReadRepository, UserClaimReadRepository>();
            services.AddScoped<IUserClaimWriteRepository, UserClaimWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        }
    }
}