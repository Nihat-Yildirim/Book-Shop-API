using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherSearchDataCommands.AddPublisherSearchData
{
    public class AddPublisherSearchDataCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
    }
}