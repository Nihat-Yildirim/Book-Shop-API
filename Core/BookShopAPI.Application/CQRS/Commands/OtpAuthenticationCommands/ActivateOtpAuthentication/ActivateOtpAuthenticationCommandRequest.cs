using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.ActivateOtpAuthentication
{
    public class ActivateOtpAuthenticationCommandRequest  : IRequest<BaseDataResponse<List<string>>>
    {
        public string? Email { get; set; }
        public string? ActivationCode { get; set; }
    }
}