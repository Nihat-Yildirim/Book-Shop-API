using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrderCountByBookId
{
    public class GetOrderCountByBookIdQueryHandler : IRequestHandler<GetOrderCountByBookIdQueryRequest, BaseDataResponse<CountDto>>
    {
        private readonly IOrderReadRepository _orderReadRepository;

        public GetOrderCountByBookIdQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<BaseDataResponse<CountDto>> Handle(GetOrderCountByBookIdQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _orderReadRepository.Table
                .Include(x => x.Basket)
                .ThenInclude(x => x.BasketItems.Where(x => x.BookId == request.BookId))
                .Where(x => x.Send == true && x.Pay == true && x.Comfirm == true)
                .AsNoTracking()
                .CountAsync();

            return new SuccessDataResponse<CountDto>(new CountDto()
            {
                Count = result
            });
        }
    }
}