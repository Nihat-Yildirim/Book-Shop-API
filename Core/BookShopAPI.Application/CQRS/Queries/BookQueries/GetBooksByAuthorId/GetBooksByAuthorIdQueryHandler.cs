using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByAuthorId
{
    public class GetBooksByAuthorIdQueryHandler : IRequestHandler<GetBooksByAuthorIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;
        public GetBooksByAuthorIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByAuthorIdQueryRequest request, CancellationToken cancellationToken)
        {
            var bookDatas = await _bookReadRepository.Table
                                  .Include(x => x.Authors)
                                  .Include(x => x.BookPictures)
                                  .ThenInclude(x => x.File)
                                  .Where(x => x.Authors.Any(x => x.Id == request.Id))
                                  .Take(request.Size)
                                  .Skip(request.Size * request.Page)
                                  .AsNoTracking()
                                  .ToListAsync();

            List<BookDto> responseDatas = new();
            foreach(var book in bookDatas)
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