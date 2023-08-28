﻿using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.RefreshTokenRepositories
{
    public interface IRefreshTokenWriteRepository : IWriteRepository<RefreshToken>
    {
    }
}