using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCode.VerifyMailComfirmCode
{
    public class VerifyMailComfirmCodeCommandRequest : IRequest<BaseResponse>
    {
        public string? Email { get; set; }
        public string? Code { get; set; }
    }
}