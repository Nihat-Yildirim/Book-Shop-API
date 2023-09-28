using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrderCountByBookId
{
    public class GetOrderCountByBookIdQueryRequest : IRequest<BaseDataResponse<CountDto>>
    {
        public int BookId { get; set; }
    }
}