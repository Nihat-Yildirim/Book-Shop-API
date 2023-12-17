using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetUserFavoriteBooks
{
    public class GetUserFavoriteBooksQueryHandler : IRequestHandler<GetUserFavoriteBooksQueryRequest, BaseDataResponse<List<FavoriteBookDto>>>
    {
        private readonly IFavoriteBookReadRepository _favoriteBookReadRepository;

        public GetUserFavoriteBooksQueryHandler(IFavoriteBookReadRepository favoriteBookReadRepository)
        {
            _favoriteBookReadRepository = favoriteBookReadRepository;
        }

        public async Task<BaseDataResponse<List<FavoriteBookDto>>> Handle(GetUserFavoriteBooksQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _favoriteBookReadRepository.GetWhere(x => x.UserId == request.UserId, false)
                              .Select(x => new FavoriteBookDto
                              {
                                  Id = x.Id,
                                  BookId = x.BookId
                              }).ToListAsync();

            return new SuccessDataResponse<List<FavoriteBookDto>>(response);    
        }
    }
}