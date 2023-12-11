using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Queries.LanguageQueries.GetAll;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class LanguagesController : BaseController
    {
        public LanguagesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAll")]
        //[AuthorizationFilter("Admin")]
        [CacheFilter(72,24)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryRequest request)
            => await DataResponse(request);
    }
}
