using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.BookSearchDataCommands.AddBookSearchData;
using BookShopAPI.Application.CQRS.Queries.BookSearchDataQueries.GetSelectedBookSearchDatasForDays;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class BookSearchDatasController : BaseController
    {
        public BookSearchDatasController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] AddBookSearchDataCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetSelectedBookSearchDatasForDays")]
        public async Task<IActionResult> GetSelectedBookSearchDatasForDays([FromQuery] GetSelectedBookSearchDatasForDaysQueryRequest request)
            => await DataResponse(request);

    }
}
