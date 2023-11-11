using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId
{
    public class GetBooksByPublisherIdQueryHandler : IRequestHandler<GetBooksByPublisherIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;
        public GetBooksByPublisherIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByPublisherIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bookDatas = await _bookReadRepository.Table
                                    .Include(x => x.BookPictures)
                                    .ThenInclude(x => x.File)
                                    .Where(x => x.PublisherId == request.Id)
                                    .Skip(request.Size * request.Page)
                                    .Take(request.Size)
                                    .AsNoTracking()
                                    .ToListAsync();
            
            List<BookDto> responseDatas = new();
            foreach (var book in bookDatas)
            {
                BookDto bookDto = new()
                {
                    BookName = book.BookName,
                    Description = book.Description,
                    Dimension = book.Dimension,
                    Id = book.Id,
                    ISBN = book.ISBN,
                    PaperType = book.PaperType,
                    PageOfNumber = book.PageOfNumber,
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