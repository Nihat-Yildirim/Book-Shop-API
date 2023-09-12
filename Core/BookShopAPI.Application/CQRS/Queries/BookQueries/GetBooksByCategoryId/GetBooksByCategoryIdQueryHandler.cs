using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryId
{
    public class GetBooksByCategoryIdQueryHandler : IRequestHandler<GetBooksByCategoryIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;

        public GetBooksByCategoryIdQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        //TODO burada yazılan işlemlerin tamamını bir view ile yapabilisin sonra yap !
        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var resultDatas = await _categoryReadRepository.Table
                                .Include(x => x.Books.Where(x => x.DeletedDate == null).Skip(request.Page * request.Size).Take(request.Size))
                                    .ThenInclude(x => x.Authors)
                                .Include(x => x.Books)
                                    .ThenInclude(x => x.BookPictures)
                                        .ThenInclude(x => x.File)
                                .Include(x => x.Books)
                                    .ThenInclude(x => x.Categories)
                                .Include(x => x.Books)
                                    .ThenInclude(x => x.Publisher)
                                .Include(x => x.Books)
                                    .ThenInclude(x => x.Language)
                                .Where(x => x.Id == request.Id)
                                .ToListAsync();

            List<BookDto> responseDatas = new();

            resultDatas.ForEach(data =>
            {
                data.Books.ToList().ForEach(book =>
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
                        BookPictureUrls = book.BookPictures?.ToList().Select(x => FileUrlHelper.Generate(x.File.FilePath)).ToList(),
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

                    responseDatas.Add(bookDto);
                });
            });

            return new SuccessDataResponse<List<BookDto>>(responseDatas);
        }
    }
}