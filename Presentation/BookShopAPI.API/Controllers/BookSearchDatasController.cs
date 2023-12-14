using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.BookSearchDataCommands.AddBookSearchData;
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


    }
}
