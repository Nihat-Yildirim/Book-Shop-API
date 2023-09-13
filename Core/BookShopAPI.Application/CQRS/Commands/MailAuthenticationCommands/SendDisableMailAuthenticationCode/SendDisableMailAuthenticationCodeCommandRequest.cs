using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.SendDisableMailAuthenticationCode
{
    public class SendDisableMailAuthenticationCodeCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
    }
}