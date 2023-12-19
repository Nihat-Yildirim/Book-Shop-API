using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetSelectedBookFavoriteDatasForDays
{
    public class GetSelectedBookFavoriteDatasForDaysQueryHandler : IRequestHandler<GetSelectedBookFavoriteDatasForDaysQueryRequest, BaseDataResponse<List<FavoriteBookCountForDaysDto>>>
    {
        private readonly IFavoriteBookReadRepository _favoriteBookReadRepository;

        public GetSelectedBookFavoriteDatasForDaysQueryHandler(IFavoriteBookReadRepository favoriteBookReadRepository)
        {
            _favoriteBookReadRepository = favoriteBookReadRepository;
        }

        public async Task<BaseDataResponse<List<FavoriteBookCountForDaysDto>>> Handle(GetSelectedBookFavoriteDatasForDaysQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-6);
            var datas = await _favoriteBookReadRepository.GetWhere(x => x.BookId == request.BookId && x.CreatedDate > minDate, false).ToListAsync();
            List<FavoriteBookCountForDaysDto> response = new();

            for (int i = 0; i <= 6; i++)
            {
                response.Add(new FavoriteBookCountForDaysDto
                {
                    Date = minDate.AddDays(i).ToString("dd"),
                    FavoriteBookCount = datas.Where(x => x.CreatedDate.Day == minDate.AddDays(i).Day).Count()
                });
            }

            return new SuccessDataResponse<List<FavoriteBookCountForDaysDto>>(response);
        }
    }
}