using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.AuthorSearchDataCommands.AddAuthorSearchData;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AuthorSearchDatasController : BaseController
    {
        public AuthorSearchDatasController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] AddAuthorSearchDataCommandRequest request)
            => await NoDataResponse(request);   
    }
}
