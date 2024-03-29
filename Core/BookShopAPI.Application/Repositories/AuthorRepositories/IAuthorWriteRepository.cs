﻿using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.AuthorRepositories
{
    public interface IAuthorWriteRepository : IWriteRepository<Author>
    {
    }
}