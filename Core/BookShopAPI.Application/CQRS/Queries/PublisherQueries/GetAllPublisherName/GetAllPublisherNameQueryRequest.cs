using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetAllPublisherName
{
    public class GetAllPublisherNameQueryRequest : IRequest<BaseDataResponse<List<ShortPublisherDto>>>
    {
    }
}