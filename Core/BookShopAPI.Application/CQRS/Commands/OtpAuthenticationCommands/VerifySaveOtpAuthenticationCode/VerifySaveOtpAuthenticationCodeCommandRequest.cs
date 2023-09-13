using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.VerifySaveOtpAuthenticationCode
{
    public class VerifySaveOtpAuthenticationCodeCommandRequest : IRequest<BaseDataResponse<List<string>>>
    {
        public string? Email { get; set; }
        public string? Code { get; set; }
    }
}