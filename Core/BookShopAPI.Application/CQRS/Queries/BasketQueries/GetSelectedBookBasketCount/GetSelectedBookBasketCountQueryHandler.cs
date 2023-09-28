using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetSelectedBookBasketCount
{
    public class GetSelectedBookBasketCountQueryHandler : IRequestHandler<GetSelectedBookBasketCountQueryRequest, BaseDataResponse<CountDto>>
    {
        private readonly IBasketReadRepository _basketReadRepository;

        public GetSelectedBookBasketCountQueryHandler(IBasketReadRepository basketReadRepository)
        {
            _basketReadRepository = basketReadRepository;
        }

        public async Task<BaseDataResponse<CountDto>> Handle(GetSelectedBookBasketCountQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _basketReadRepository.Table
                .Include(x => x.BasketItems.Where(x => x.BookId == request.BookId))
                .Where(x => x.Visible == true)
                .AsNoTracking()
                .CountAsync();

            return new SuccessDataResponse<CountDto>(new CountDto()
            {
                Count = result
            });
        }
    }
}