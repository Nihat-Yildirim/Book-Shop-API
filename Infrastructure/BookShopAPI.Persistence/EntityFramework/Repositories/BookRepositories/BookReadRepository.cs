using BookShopAPI.Application.DTOs.AuthorsDTOs;
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
                    .Include(x => x.Authors)
                    .Include(x => x.Categories)
                    .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    where book.DeletedDate == null
                    join publisher in _context.Publishers
                        on book.PublisherId equals publisher.Id
                    join language in _context.Languages
                        on book.LanguageId equals language.Id
                    select new BookDto
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
                        BookPictureUrls = book.BookPictures.ToList().Select(x => FileUrlHelper.Generate(x.File.FilePath)).ToList(),
                        Authors = book.Authors.Select(x => new ShortAuthorDto
                        {
                            Id = x.Id,
                            Name = x.FirstName + " " + x.LastName
                        }).ToList(),
                        Categories = book.Categories.Select(x => new ShortCategoryDto
                        {
                            Id = x.Id,
                            CategoryName = x.CategoryName,
                        }).ToList()
                    };

            if(filter != null)
                return await query.AsNoTracking()
                        .Where(filter)
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .ToListAsync();

            return await query.AsNoTracking()
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .ToListAsync();
        }

        public async Task<List<BookForAdminDto>> GetBookForAdminDtosAsync(Pagination pagination, Expression<Func<BookForAdminDto, bool>> filter = null)
        {
            IQueryable<BookForAdminDto> query;

            query = from book in _context.Books
                    .Include(x => x.Authors)
                    .Include(x => x.Categories)
                    .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    join publisher in _context.Publishers
                        on book.PublisherId equals publisher.Id
                    join language in _context.Languages
                        on book.LanguageId equals language.Id
                    select new BookForAdminDto
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
                        CreatedDate = book.CreatedDate,
                        UpdatedDate = book.UpdatedDate,
                        DeletedDate = book.DeletedDate,
                        BookPictureUrls = book.BookPictures.ToList().Select(x => new BookPictureDto
                        {
                            Id = x.Id,
                            Url = FileUrlHelper.Generate(x.File.FilePath)
                        }).ToList(),
                        Authors = book.Authors.Select(x => new ShortAuthorDto
                        {
                            Id = x.Id,
                            Name = x.FirstName + " " + x.LastName
                        }).ToList(),
                        Categories = book.Categories.Select(x => new ShortCategoryDto
                        {
                            Id = x.Id,
                            CategoryName = x.CategoryName,
                        }).ToList()
                    };

            if(filter != null)
                return await query.AsNoTracking()
                        .Where(filter)
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .ToListAsync();

            return await query.AsNoTracking()
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size)
                        .ToListAsync();
        }

        public async Task<BookDto> GetSingleBookDtoAsync(Expression<Func<BookDto, bool>> filter)
        {
            IQueryable<BookDto> query;
            query = from book in _context.Books
                   .Include(x => x.Authors)
                   .Include(x => x.Categories)
                   .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    where book.DeletedDate == null
                    join publisher in _context.Publishers
                         on book.PublisherId equals publisher.Id
                    join language in _context.Languages
                         on book.LanguageId equals language.Id
                    select new BookDto
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
                        BookPictureUrls = book.BookPictures.ToList().Select(x => FileUrlHelper.Generate(x.File.FilePath)).ToList(),
                        Authors = book.Authors.Select(x => new ShortAuthorDto
                        {
                            Id = x.Id,
                            Name = x.FirstName + " " + x.LastName
                        }).ToList(),
                        Categories = book.Categories.Select(x => new ShortCategoryDto
                        {
                            Id = x.Id,
                            CategoryName = x.CategoryName,
                        }).ToList()
                    };
            return await query.AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<BookForAdminDto> GetSingleBookForAdminDtoAsync(Expression<Func<BookForAdminDto, bool>> filter)
        {
            IQueryable<BookForAdminDto> query;

            query = from book in _context.Books
                    .Include(x => x.Authors)
                    .Include(x => x.Categories)
                    .Include(x => x.BookPictures).ThenInclude(x => x.File)
                    join publisher in _context.Publishers
                        on book.PublisherId equals publisher.Id
                    join language in _context.Languages
                        on book.LanguageId equals language.Id
                    select new BookForAdminDto
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
                        CreatedDate = book.CreatedDate,
                        UpdatedDate = book.UpdatedDate,
                        DeletedDate = book.DeletedDate,
                        BookPictureUrls = book.BookPictures.ToList().Select(x => new BookPictureDto
                        {
                            Id = x.Id,
                            Url = FileUrlHelper.Generate(x.File.FilePath)
                        }).ToList(),
                        Authors = book.Authors.Select(x => new ShortAuthorDto
                        {
                            Id = x.Id,
                            Name = x.FirstName + " " + x.LastName
                        }).ToList(),
                        Categories = book.Categories.Select(x => new ShortCategoryDto
                        {
                            Id = x.Id,
                            CategoryName = x.CategoryName,
                        }).ToList()
                    };

            return await query.AsNoTracking().SingleOrDefaultAsync(filter);
        }
    }
}