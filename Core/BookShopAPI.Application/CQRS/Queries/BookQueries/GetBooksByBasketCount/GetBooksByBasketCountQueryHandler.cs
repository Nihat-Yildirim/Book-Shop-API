using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByBasketCount
{
    public class GetBooksByBasketCountQueryHandler : IRequestHandler<GetBooksByBasketCountQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBooksByBasketCountQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByBasketCountQueryRequest request, CancellationToken cancellationToken)
        {
            var resultDatas = await _bookReadRepository.Table
                              .Include(x => x.BasketItems)
                                .ThenInclude(x => x.Basket)
                              .Include(x => x.Categories)
                              .Include(x => x.Publisher)
                              .Include(x => x.Language)
                              .Include(x => x.Authors)
                              .Include(x => x.BookPictures.Where(x => x.ShowOrder == 1))
                                .ThenInclude(x => x.File)
                              .Where(x => x.Categories.SingleOrDefault(x => x.Id == 10) == null && x.BasketItems.Count != 0)
                              .OrderByDescending(x => x.BasketItems.Where(x => x.Basket.Visible == true).Sum(x => x.Quantity))
                              .Take(request.Size)
                              .Skip(request.Size * request.Page)
                              .ToListAsync();

            List<BookDto> responseDatas = new();
            resultDatas.ForEach(book =>
            {
                BookDto bookDto = new()
                {
                    Id = book.Id,
                    Publisher = new()
                    {
                        Id = book.Publisher.Id,
                        Name = book.Publisher.Name
                    },
                    Language = new()
                    {
                        Id = book.Language.Id,
                        Name = book.Language.Name
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
                    PictureUrls = book.BookPictures?.ToList().Select(x => FileUrlHelper.Generate(x.File.FilePath)).ToList(),
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

                responseDatas.Add(bookDto);
            });

            return new SuccessDataResponse<List<BookDto>>(responseDatas);
        }
    }
}