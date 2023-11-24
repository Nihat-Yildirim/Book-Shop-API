using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.PublisherCommands.AddPublisher;
using BookShopAPI.Application.CQRS.Commands.PublisherCommands.DeletePublisher;
using BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisher;
using BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisherLogo;
using BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetAllPublishers;
using BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherById;
using BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherByPattern;
using BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherByPatternForAdmin;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class PublishersController : BaseController
    {
        public PublishersController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddPublisher")]
        public async Task<IActionResult> AddPublisher([FromForm] AddPublisherCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeletePublisher")]
        public async Task<IActionResult> DeletePublisher([FromQuery] DeletePublisherCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdatePublisherLogo")]
        public async Task<IActionResult> UpdatePublisherLogo([FromForm] UpdatePublisherLogoCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdatePublisher")]
        public async Task<IActionResult> UpdatePublisher([FromQuery] UpdatePublisherCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAllPublisher")]
        [CacheFilter(10, 2)]
        public async Task<IActionResult> GetAllPublisher([FromQuery] GetAllPublisherQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetPublisherById")]
        [CacheFilter(10, 2)]
        public async Task<IActionResult> GetPublisherById([FromQuery] GetPublisherByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetPublisherByPattern")]
        [CacheFilter(10, 2)]
        public async Task<IActionResult> GetPublisherByPattern([FromQuery] GetPublisherByPatternQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetPublisherByPatternForAdmin")]
        [CacheFilter(10, 2)]
        public async Task<IActionResult> GetPublisherByPatternForAdmin([FromQuery] GetPublisherByPatternForAdminQueryRequest request)
            => await DataResponse(request);
    }
}