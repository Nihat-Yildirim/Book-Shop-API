﻿using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.AuthorSearchDataRepositories
{
    public interface IAuthorSearchDataWriteRepository : IWriteRepository<AuthorSearchData>
    {
    }
}