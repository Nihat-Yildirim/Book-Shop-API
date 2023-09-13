using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.ActivateOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.AddOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.DisableOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.SaveOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.VerifySaveOtpAuthenticationCode;
using BookShopAPI.Application.CQRS.Commands.UserClaimCommands.UpdateUserClaim;
using BookShopAPI.Application.CQRS.Commands.UserCommands.CustomerRegister;
using BookShopAPI.Application.CQRS.Queries.OtpAuthenticationQueries.OtpAuthenticationLogin;
using BookShopAPI.Application.CQRS.Queries.UserQueries.Login;
using BookShopAPI.Application.CQRS.Queries.UserQueries.RefreshTokenLogin;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AuthenticationsController : BaseController
    {
        public AuthenticationsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("UserRegister")]
        public async Task<IActionResult> UserRegister([FromQuery] UserRegisterCommandRequest request)
            => await NoDataResponse(request);

        [HttpPost("AddOtpAuthentication")]
        public async Task<IActionResult> AddOtpAuthentication([FromQuery] AddOtpAuthenticationCommandRequest request)
            => await DataResponse(request);

        [HttpPut("VerifyMailComfirmCode")]
        public async Task<IActionResult> VerifyMailComfirmCode([FromQuery] VerifyMailComfirmCodeCommandRequest request)
            => await NoDataResponse(request);

        [HttpPut("SaveOtpAuthentication")]
        public async Task<IActionResult> SaveOtpAuthentication([FromQuery] SaveOtpAuthenticationCommandRequest request)
            => await DataResponse(request);

        [HttpPut("VerifySaveOtpAuthenticationCode")]
        public async Task<IActionResult> VerifySaveOtpAuthenticationCode([FromQuery] VerifySaveOtpAuthenticationCodeCommandRequest request)
            => await DataResponse(request);

        [HttpPut("ActivateOtpAuthentication")]
        public async Task<IActionResult> ActivateOtpAuthentication([FromQuery] ActivateOtpAuthenticationCommandRequest request)
            => await DataResponse(request);

        [HttpDelete("DisableOtpAuthentication")]
        public async Task<IActionResult> DisableOtpAuthentication([FromQuery] DisableOtpAuthenticationCommandRequest request)
            => await NoDataResponse(request);

        [HttpPut("UpdateUserClaim")]
        public async Task<IActionResult> UpdateUserClaim([FromQuery] UpdateUserClaimCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromQuery] LoginQueryRequest request)
            => await DataResponse(request);

        [HttpGet("RefreshTokenLogin")]
        public async Task<IActionResult> RefreshTokenLogin([FromQuery] RefreshTokenLoginQueryRequest request)
            => await DataResponse(request);

        [HttpGet("OtpAuthenticationLogin")]
        public async Task<IActionResult> OtpAuthenticationLogin([FromQuery] OtpAuthenticationLoginQueryRequest request)
            => await DataResponse(request);
    }
}