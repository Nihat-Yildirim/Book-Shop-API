using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.MailComfirmCode.VerifyMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.User.CustomerRegister;
using BookShopAPI.Application.CQRS.Queries.User.Login;
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
        {
            return await ActionNoDataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> VerifyMailComfirmCode([FromQuery] VerifyMailComfirmCodeCommandRequest request)
        {
            return await ActionNoDataResponse(request);
        }

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] LoginQueryRequest request)
        {
            return await ActionDataResponse(request);
        }
    }
}