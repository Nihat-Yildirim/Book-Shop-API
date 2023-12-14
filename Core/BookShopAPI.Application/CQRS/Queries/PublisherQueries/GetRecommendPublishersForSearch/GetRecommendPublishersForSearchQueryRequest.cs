using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetRecommendPublishersForSearch
{
    public class GetRecommendPublishersForSearchQueryRequest : IRequest<BaseDataResponse<List<ShortPublisherDto>>>
    {
    }
}