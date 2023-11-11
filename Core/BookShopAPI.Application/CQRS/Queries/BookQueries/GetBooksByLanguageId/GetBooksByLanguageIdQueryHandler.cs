using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByLanguageId
{
    public class GetBooksByLanguageIdQueryHandler : IRequestHandler<GetBooksByLanguageIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBooksByLanguageIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByLanguageIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bookDatas = await _bookReadRepository.GetWhere(x => x.LanguageId == request.Id && x.DeletedDate == null, false).ToListAsync();
            
            List<BookDto> responseDatas = new();
            bookDatas.ForEach(book =>
            {
                BookDto bookDto = new()
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

                responseDatas.Add(bookDto);
            });

            return new SuccessDataResponse<List<BookDto>>(responseDatas);
        }
    }
}