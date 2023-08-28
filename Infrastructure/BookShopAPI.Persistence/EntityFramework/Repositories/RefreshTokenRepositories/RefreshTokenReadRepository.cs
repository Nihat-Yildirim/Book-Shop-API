﻿using BookShopAPI.Application.Repositories.RefreshTokenRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.RefreshTokenRepositories
{
    public sealed class RefreshTokenReadRepository : BaseReadRepository<RefreshToken>, IRefreshTokenReadRepository
    {
        public RefreshTokenReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}