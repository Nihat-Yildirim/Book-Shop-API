﻿using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookRepositories
{
    public sealed class BookReadRepository : BaseReadRepository<Book>, IBookReadRepository
    {
        public BookReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<List<BookDto>> GetBookDtosAsync(Pagination pagination, Expression<Func<BookDto, bool>> filter = null)
        {
            IQueryable<BookDto> query;

            query = from book in _context.Books
                    .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    where book.DeletedDate == null
                    select new BookDto
                    {
                        Id = book.Id,
                        BookName = book.BookName,
                        ISBN = book.ISBN,
                        PaperType = book.PaperType,
                        SkinType = book.SkinType,
                        Dimension = book.Dimension,
                        Description = book.Description,
                        ReleaseDate = book.ReleaseDate,
                        PageOfNumber = book.PageOfNumber,
                        Stock = book.Stock,
                        Price = book.Price,
                        PictureUrls = book.BookPictures.ToList().Select(x => new BookPictureDto
                        {
                            Id = x.Id,
                            ShowOrder = x.ShowOrder,
                            PictureUrl = FileUrlHelper.Generate(x.File.FilePath)
                        }).ToList(),
                    };

            if(filter != null)
                return await query.AsNoTracking()
                        .Where(filter)
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .AsNoTracking()
                        .ToListAsync();

            return await query.AsNoTracking()
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .AsNoTracking()
                        .ToListAsync();
        }

        public async Task<BookDetailDto> GetSingleBookBookDetailDtoAsync(Expression<Func<BookDetailDto, bool>> filter)
        {
            IQueryable<BookDetailDto> query;
            query = from book in _context.Books
                   .Include(x => x.Authors)
                   .Include(x => x.Categories)
                   .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    where book.DeletedDate == null
                    join publisher in _context.Publishers
                         on book.PublisherId equals publisher.Id
                    join language in _context.Languages
                         on book.LanguageId equals language.Id
                    select new BookDetailDto
                    {
                        Id = book.Id,
                        Publisher = new()
                        {
                            Id = publisher.Id,
                            Name = publisher.Name
                        },
                        Language = new()
                        {
                            Id = language.Id,
                            Name = language.Name
                        },
                        BookName = book.BookName,
                        ISBN = book.ISBN,
                        PaperType = book.PaperType,
                        SkinType = book.SkinType,
                        Dimension = book.Dimension,
                        Description = book.Description,
                        ReleaseDate = book.ReleaseDate,
                        PageOfNumber = book.PageOfNumber,
                        Stock = book.Stock,
                        Price = book.Price,
                        PictureUrls = book.BookPictures.ToList().Select(x => new BookPictureDto
                        {
                            Id = x.Id,
                            ShowOrder = x.ShowOrder,
                            PictureUrl = FileUrlHelper.Generate(x.File.FilePath)
                        }).ToList(),
                        Authors = book.Authors.Select(x => new ShortAuthorDto
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList(),
                        Categories = book.Categories.Select(x => new ShortCategoryDto
                        {
                            Id = x.Id,
                            CategoryName = x.CategoryName,
                        }).ToList()
                    };
            return await query.AsNoTracking()
                    .SingleOrDefaultAsync(filter);
        }
    }
}