using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCommentCount
{
    public class GetBooksByCommentCountQueryHandler : IRequestHandler<GetBooksByCommentCountQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBooksByCommentCountQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByCommentCountQueryRequest request, CancellationToken cancellationToken)
        {
            var resultDatas = await _bookReadRepository.Table
                              .Include(x => x.Comments.Where(x => x.DeletedDate == null))
                              .Include(x => x.BookPictures)
                              .ThenInclude(x => x.File)
                              .Where(x => x.Comments.Count > 0 && x.Categories.SingleOrDefault(x => x.Id == 10) == null)
                              .OrderByDescending(x => x.Comments.Count)
                              .AsNoTracking()
                              .Take(request.Size)
                              .Skip(request.Size * request.Page)
                              .ToListAsync();

            List<BookDto> responseDatas = new();
            resultDatas.ForEach(book =>
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