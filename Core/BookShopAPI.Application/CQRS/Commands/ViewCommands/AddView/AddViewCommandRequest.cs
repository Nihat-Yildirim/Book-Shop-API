using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ViewCommands.AddView
{
    public class AddViewCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
    }
}