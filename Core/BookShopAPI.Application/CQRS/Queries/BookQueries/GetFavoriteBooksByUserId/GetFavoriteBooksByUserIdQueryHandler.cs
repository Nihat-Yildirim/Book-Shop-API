using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetFavoriteBooksByUserId
{
    public class GetFavoriteBooksByUserIdQueryHandler : IRequestHandler<GetFavoriteBooksByUserIdQueryRequest, BaseDataResponse<ResultFavoriteBookDto>>
    {
        private readonly IFavoriteBookReadRepository _favoriteBookReadRepository;

        public GetFavoriteBooksByUserIdQueryHandler(IFavoriteBookReadRepository favoriteBookReadRepository)
        {
            _favoriteBookReadRepository = favoriteBookReadRepository;
        }

        public async Task<BaseDataResponse<ResultFavoriteBookDto>> Handle(GetFavoriteBooksByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseFavoriteBook = await _favoriteBookReadRepository.GetWhere(x => x.UserId == request.UserId)
                                       .Include(x => x.Book)
                                       .ThenInclude(x => x.BookPictures)
                                       .ThenInclude(x => x.File)
                                       .Skip(request.Size * request.Page)
                                       .Take(request.Size)
                                       .AsNoTracking()
                                       .Select(x => new FavoriteBookDetailDto
                                       {
                                           BookId = x.BookId,
                                           BookName = x.Book.BookName,
                                           FavoriteId = x.Id,
                                           Price = x.Book.Price,
                                           PictureUrl = FileUrlHelper.Generate(x.Book.BookPictures.SingleOrDefault(x => x.ShowOrder == 1).File.FilePath)
                                       })   
                                       .ToListAsync();

            var favoriteBookCount = _favoriteBookReadRepository.GetWhere(x => x.UserId == request.UserId).Count();

            return new SuccessDataResponse<ResultFavoriteBookDto>(new ResultFavoriteBookDto
            {
                FavoriteBooks = responseFavoriteBook,
                FavoriteBookCount = favoriteBookCount
            });
        }
    }
}