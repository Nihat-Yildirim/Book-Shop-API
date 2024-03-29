﻿using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BasketRepositories
{
    public sealed class BasketReadRepository : BaseReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<BasketDto> GetBasketDtoAsync(int userId)
        {
            IQueryable<BasketDto> query;
            query = from user in _context.Users
                    join userClaim in _context.UserClaims
                    on user.Id equals userClaim.UserId
                    where user.Id == userId && userClaim.ClaimId == (int)Claims.Customer
                    join basket in _context.Baskets
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.BookPictures)
                    .ThenInclude(x => x.File)
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.Publisher)
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.Authors)
                    on user.Id equals basket.UserId
                    select new BasketDto
                    {
                        UserId = user.Id,
                        BasketId = basket.Id,
                        BasketItems = basket.BasketItems.ToList().Select(basketItem => new BasketItemDto
                        {
                            Publisher = new()
                            {
                                Id = basketItem.Book.Publisher.Id,
                                Name = basketItem.Book.Publisher.Name
                            },
                            Authors = GetAuthors(basketItem.Book.Authors),
                            BasketItemId = basketItem.Id,
                            BookId = basketItem.BookId,
                            BookName = basketItem.Book.BookName,
                            Quantity = basketItem.Quantity,
                            Price = basketItem.Book.Price,
                            BookPictureUrl = FileUrlHelper.Generate(basketItem.Book.BookPictures.SingleOrDefault(x => x.ShowOrder == 1).File.FilePath),
                            Selected = basketItem.Selected,
                        }).ToList()
                    };

            return await query.SingleAsync();
        }

        public async Task<List<BasketForAdminDto>> GetBasketForAdminDtosAsync()
        {
            IQueryable<BasketForAdminDto> query;
            query = from user in _context.Users
                    join userClaim in _context.UserClaims
                    on user.Id equals userClaim.UserId
                    where userClaim.ClaimId == (int)Claims.Customer
                    join basket in _context.Baskets
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.BookPictures)
                    .ThenInclude(x => x.File)
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.Publisher)
                    .Include(x => x.BasketItems)
                    .ThenInclude(x => x.Book)
                    .ThenInclude(x => x.Authors)
                    on user.Id equals basket.UserId
                    select new BasketForAdminDto
                    {
                        UserId = user.Id,
                        BasketId = basket.Id,
                        BasketItems = basket.BasketItems.ToList().Select(basketItem => new BasketItemDto
                        {
                            Publisher = new()
                            {
                                Id = basketItem.Book.Publisher.Id,
                                Name = basketItem.Book.Publisher.Name
                            },
                            Authors = GetAuthors(basketItem.Book.Authors),
                            BasketItemId = basketItem.Id,
                            BookId = basketItem.BookId,
                            BookName = basketItem.Book.BookName,
                            Quantity = basketItem.Quantity,
                            Price = basketItem.Book.Price,
                            BookPictureUrl = FileUrlHelper.Generate(basketItem.Book.BookPictures.SingleOrDefault(x => x.ShowOrder == 1).File.FilePath),
                            Selected = basketItem.Selected,
                        }).ToList(),
                        CreatedDate = basket.CreatedDate,
                        UpdatedDate = basket.UpdatedDate
                    };

            return await query.ToListAsync();
        }

        private static List<ShortAuthorDto> GetAuthors(ICollection<Author> authors)
        {
            List<ShortAuthorDto> results = new();
            foreach(var author in authors)
            {
                ShortAuthorDto shortAuthorDto = new();
                shortAuthorDto.Id = author.Id;
                shortAuthorDto.Name = author.Name;
                results.Add(shortAuthorDto);
            }

            return results;
        }
    }
}