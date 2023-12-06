using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.ViewCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class ViewsController : BaseController
    {
        public ViewsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] AddViewCommandRequest request)
            => await NoDataResponse(request);
    }
}