using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.UserClaimCommands.UpdateUserClaim;
using BookShopAPI.Application.CQRS.Commands.UserCommands.CustomerRegister;
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

        [HttpPost]
        public async Task<IActionResult> UserRegister([FromQuery] UserRegisterCommandRequest request)
            => await NoDataResponse(request);

        [HttpPut]
        public async Task<IActionResult> VerifyMailComfirmCode([FromQuery] VerifyMailComfirmCodeCommandRequest request)
            => await NoDataResponse(request);

        [HttpPut("UpdateUserClaim")]
        public async Task<IActionResult> UpdateUserClaim([FromQuery] UpdateUserClaimCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] LoginQueryRequest request)
            => await DataResponse(request);

        [HttpGet("RefreshTokenLogin")]
        public async Task<IActionResult> RefreshTokenLogin([FromQuery] RefreshTokenLoginQueryRequest request)
            => await DataResponse(request);
    }
}