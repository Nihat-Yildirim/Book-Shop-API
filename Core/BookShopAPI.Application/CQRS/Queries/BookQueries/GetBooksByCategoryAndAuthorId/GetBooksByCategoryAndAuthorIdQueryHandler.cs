using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId
{
    public class GetBooksByCategoryAndAuthorIdQueryHandler : IRequestHandler<GetBooksByCategoryAndAuthorIdQueryRequest, BaseDataResponse<List<BookDto>>> 
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBooksByCategoryAndAuthorIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByCategoryAndAuthorIdQueryRequest request, CancellationToken cancellationToken)
        {
            List<List<Book>> bookDatas = new();
            var authorBooks = await _bookReadRepository.Table
                               .Include(x => x.Authors)
                               .Include(x => x.BasketItems)
                               .ThenInclude(x => x.Basket)
                               .Include(x => x.BookPictures)
                               .ThenInclude(x => x.File)
                               .Where(x => x.Id != request.BookId)
                               .Where(x => x.Authors.Any(y => request.AuthorIds.Any(z => z == y.Id)))
                               .OrderByDescending(x => x.BasketItems.Where(x => x.Basket.Visible == true).Sum(x => x.Quantity))
                               .Take(20)
                               .AsNoTracking()
                               .ToListAsync();
            bookDatas.Add(authorBooks);

            int bookQuantity = 0;
            if(authorBooks.Count != 20)
                bookQuantity = 40 - authorBooks.Count;

            if (authorBooks.Count == 20)
                bookQuantity = 20;

           var categoryBooks = await _bookReadRepository.Table
                                .Include(x => x.Categories)
                                .Include(x => x.BasketItems)
                                .ThenInclude(x => x.Basket)
                                .Include(x => x.BookPictures)
                                .ThenInclude(x => x.File)
                                .Where(x => x.Id != request.BookId && x.Categories.Any(y => request.CategoryIds.Any(z => z == y.Id)) && !authorBooks.Contains(x))
                                .OrderByDescending(x => x.BasketItems.Where(x => x.Basket.Visible == true).Sum(x => x.Quantity))
                                .Take(bookQuantity) 
                                .AsNoTracking()
                                .ToListAsync();
            bookDatas.Add(categoryBooks);

            List<BookDto> response = new();
            foreach (var datas in bookDatas)
            {
                foreach (var book in datas)
                {
                    BookDto bookDto = new()
                    {
                        Id = book.Id,
                        BookName = book.BookName,
                        Description = book.Description,
                        Dimension = book.Dimension,
                        ISBN = book.ISBN,
                        PageOfNumber = book.PageOfNumber,
                        PaperType = book.PaperType,
                        Price = book.Price,
                        ReleaseDate = book.ReleaseDate,
                        SkinType = book.SkinType,
                        Stock = book.Stock,
                        PictureUrls = book.BookPictures.ToList().Select(x => new BookPictureDto
                        {
                            Id = x.Id,
                            ShowOrder = x.ShowOrder,
                            PictureUrl = FileUrlHelper.Generate(x.File.FilePath)
                        }).ToList(),
                    };
                    response.Add(bookDto);
                }
            }

            return new SuccessDataResponse<List<BookDto>>(response);
        }
    }
}