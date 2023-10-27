using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.ActivateMailAuthentication;
using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.AddMailAuthentication;
using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.DisableMailAuthentication;
using BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.SendDisableMailAuthenticationCode;
using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.NewMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.ActivateOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.AddOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.DisableOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.SaveOtpAuthentication;
using BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.VerifySaveOtpAuthenticationCode;
using BookShopAPI.Application.CQRS.Commands.UserClaimCommands.UpdateUserClaim;
using BookShopAPI.Application.CQRS.Commands.UserCommands.CustomerRegister;
using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdatePassword;
using BookShopAPI.Application.CQRS.Queries.MailAuthenticationQueries.MailAuthenticationLogin;
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

        [HttpPut("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword([FromQuery] UpdatePasswordCommandRequest request)
            => await NoDataResponse(request);

        [HttpPost("AddOtpAuthentication")]
        public async Task<IActionResult> AddOtpAuthentication([FromQuery] AddOtpAuthenticationCommandRequest request)
            => await DataResponse(request);

        [HttpPost("AddMailAuthenticaiton")]
        public async Task<IActionResult> AddMailAuthenticaiton([FromQuery] AddMailAuthenticaitonCommandRequest request)
            => await NoDataResponse(request);

        [HttpPut("VerifyMailComfirmCode")]
        public async Task<IActionResult> VerifyMailComfirmCode([FromQuery] VerifyMailComfirmCodeCommandRequest request)
            => await DataResponse(request);

        [HttpPut("NewMailComfirmCode")]
        public async Task<IActionResult> NewMailComfirmCode([FromQuery] NewMailComfirmCodeCommandRequest request)
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

        [HttpPut("ActivateMailAuthentication")]
        public async Task<IActionResult> ActivateMailAuthentication([FromQuery] ActivateMailAuthenticationCommandRequest request)
            => await NoDataResponse(request);

        [HttpPost("SendDisableMailAuthenticationCode")]
        public async Task<IActionResult> SendDisableMailAuthenticationCode([FromQuery] SendDisableMailAuthenticationCodeCommandRequest request)
            => await NoDataResponse(request);

        [HttpDelete("DisableMailAuthentication")]
        public async Task<IActionResult> DisableMailAuthentication([FromQuery] DisableMailAuthenticationCommandRequest request)
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

        [HttpGet("MailAuthenticationLogin")]
        public async Task<IActionResult> MailAuthenticationLogin([FromQuery] MailAuthenticationLoginQueryRequest request)
            => await DataResponse(request);
    }
}