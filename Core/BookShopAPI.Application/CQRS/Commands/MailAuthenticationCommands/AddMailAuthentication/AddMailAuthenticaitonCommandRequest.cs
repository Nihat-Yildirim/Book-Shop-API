using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.AddMailAuthentication
{
    public class AddMailAuthenticaitonCommandRequest : IRequest<BaseResponse>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}