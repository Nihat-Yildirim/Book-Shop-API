using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.PublisherSearchDataCommands.AddPublisherSearchData;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class PublisherSearchDatasController : BaseController
    {
        public PublisherSearchDatasController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] AddPublisherSearchDataCommandRequest request)
            => await NoDataResponse(request);
    }
}