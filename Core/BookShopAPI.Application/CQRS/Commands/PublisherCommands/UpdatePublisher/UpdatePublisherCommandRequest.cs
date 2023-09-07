using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisher
{
    public class UpdatePublisherCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
        public string? Name { get; set; }
    }
}