using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetRecommendAuthorsForSearch
{
    public class GetRecommendAuthorsForSearchQueryRequest : IRequest<BaseDataResponse<List<ShortAuthorDto>>>
    {
    }
}