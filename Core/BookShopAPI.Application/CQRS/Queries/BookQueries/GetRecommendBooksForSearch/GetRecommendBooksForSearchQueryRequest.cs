using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetRecommendBooksForSearch
{
    public class GetRecommendBooksForSearchQueryRequest : IRequest<BaseDataResponse<List<ShortBookDto>>>
    {
    }
}