using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Publisher.GetPublisherById
{
    public class GetPublisherByIdQueryRequest : IRequest<BaseDataResponse<PublisherDto>>
    {
        public int PublisherId { get; set; }
    }
}