using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Publisher.DeletePublisher
{
    public class DeletePublisherCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
    }
}