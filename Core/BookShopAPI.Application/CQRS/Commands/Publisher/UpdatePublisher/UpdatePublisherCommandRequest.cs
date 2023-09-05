using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
        public string? Name { get; set; }
    }
}