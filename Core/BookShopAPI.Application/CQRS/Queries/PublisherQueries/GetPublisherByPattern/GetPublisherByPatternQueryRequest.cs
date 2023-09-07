using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherByPattern
{
    public class GetPublisherByPatternQueryRequest : IRequest<BaseDataResponse<List<PublisherDto>>>
    {
        public string? Pattern { get; set; }
    }
}