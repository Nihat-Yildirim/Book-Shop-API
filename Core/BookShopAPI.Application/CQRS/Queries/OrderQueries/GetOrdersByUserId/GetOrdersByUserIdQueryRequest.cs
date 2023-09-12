using BookShopAPI.Application.DTOs.OrderDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrdersByUserId
{
    public class GetOrdersByUserIdQueryRequest : IRequest<BaseDataResponse<List<OrderDto>>>
    {
        public int UserId { get; set; }
    }
}