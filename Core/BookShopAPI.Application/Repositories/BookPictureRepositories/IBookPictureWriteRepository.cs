﻿using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BookPictureRepositories
{
    public interface IBookPictureWriteRepository : IWriteRepository<BookPicture>
    {
    }
}