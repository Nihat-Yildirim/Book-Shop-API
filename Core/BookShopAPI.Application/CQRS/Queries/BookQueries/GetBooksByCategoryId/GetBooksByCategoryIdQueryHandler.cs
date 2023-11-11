using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryId
{
    public class GetBooksByCategoryIdQueryHandler : IRequestHandler<GetBooksByCategoryIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;
        public GetBooksByCategoryIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bookDatas = await _bookReadRepository.Table
                            .Include(x => x.Categories)
                            .Include(x => x.BookPictures)
                            .ThenInclude(x => x.File)
                            .Where(x => x.Categories.Any(x => x.Id == request.Id))
                            .AsNoTracking()
                            .Take(request.Size)
                            .Skip(request.Size * request.Page)
                            .ToListAsync();

            List<BookDto> responseDatas = new();
            foreach (var book in bookDatas)
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

                responseDatas.Add(bookDto);
            }

            return new SuccessDataResponse<List<BookDto>>(responseDatas);
        }
    }
}