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
    [AuthorizationFilter("Admin")]
    public class PublishersController : BaseController
    {
        public PublishersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("AddPublisher")]
        public async Task<IActionResult> AddPublisher([FromForm] AddPublisherCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeletePublisher")]
        public async Task<IActionResult> DeletePublisher([FromQuery] DeletePublisherCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdatePublisherLogo")]
        public async Task<IActionResult> UpdatePublisherLogo([FromForm] UpdatePublisherLogoCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdatePublisher")]
        public async Task<IActionResult> UpdatePublisher([FromQuery] UpdatePublisherCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet("GetAllPublisher")]
        public async Task<IActionResult> GetAllPublisher([FromQuery] GetAllPublisherQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetPublisherById")]
        public async Task<IActionResult> GetPublisherById([FromQuery] GetPublisherByIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetPublisherByPattern")]
        public async Task<IActionResult> GetPublisherByPattern([FromQuery] GetPublisherByPatternQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetPublisherByPatternForAdmin")]
        public async Task<IActionResult> GetPublisherByPatternForAdmin([FromQuery] GetPublisherByPatternForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}