using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode
{
    public class VerifyMailComfirmCodeCommandRequest : IRequest<BaseDataResponse<LoginResultDto>>
    {
        public string? Email { get; set; }
        public string? Code { get; set; }
    }
}