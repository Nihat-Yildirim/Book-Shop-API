using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Publisher.GetAllPublishers
{
    public class GetAllPublisherQueryRequest : IRequest<BaseDataResponse<List<PublisherDto>>>
    {
    }
}