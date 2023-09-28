using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.NewMailComfirmCode
{
    public class NewMailComfirmCodeCommandRequest : IRequest<BaseResponse>
    {
        public string? Mail { get; set; }
    }
}