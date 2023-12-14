using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.ViewCommands.AddView;
using BookShopAPI.Application.CQRS.Queries.ViewQueries.GetSelectedBookViewDatasForDays;
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

        [HttpGet("GetSelectedBookViewDatasForDays")]
        public async Task<IActionResult> GetSelectedBookViewDatasForDay([FromQuery] GetSelectedBookViewDatasForDaysQueryRequest request)
            => await DataResponse(request);
    }
}