using BookShopAPI.Application.CQRS.Commands.MailComfirmCode.VerifyMailComfirmCode;
using BookShopAPI.Application.CQRS.Commands.User.UserRegister;
using BookShopAPI.Application.CQRS.Queries.User.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthenticationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister([FromQuery] UserRegisterCommandRequest request)
        {
            var result = await _mediator.Send(request);

            if(!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> VerifyMailComfirmCode([FromQuery] VerifyMailComfirmCodeCommandRequest request)
        {
            var result = await _mediator.Send(request);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] LoginQueryRequest request)
        {
            var result = await _mediator.Send(request);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}