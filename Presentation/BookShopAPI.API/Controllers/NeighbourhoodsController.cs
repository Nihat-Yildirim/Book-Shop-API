using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.AddNeighbourhood;
using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.DeleteNeighbourhood;
using BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.UpdateNeighbourhood;
using BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetAllNeighbourhood;
using BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodById;
using BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodsByDistrictId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class NeighbourhoodsController : BaseController
    {
        public NeighbourhoodsController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddNeighbourhood")]
        public async Task<IActionResult> AddNeighbourhood([FromQuery] AddNeighbourhoodCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateNeighbourhood")]
        public async Task<IActionResult> UpdateNeighbourhood([FromQuery] UpdateNeighbourhoodCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteNeighbourhood")]
        public async Task<IActionResult> DeleteNeighbourhood([FromQuery] DeleteNeighbourhoodCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAllNeighbourhood")]
        [CacheFilter(72, 24)]
        public async Task<IActionResult> GetAllNeighbourhood([FromQuery] GetAllNeighbourhoodQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetNeighbourhoodById")]
        [CacheFilter(25, 5)]
        public async Task<IActionResult> GetNeighbourhoodById([FromQuery] GetNeighbourhoodByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetNeighbourhoodByDistrictId")]
        [CacheFilter(48, 12)]
        public async Task<IActionResult> GetNeighbourhoodByDistrictId([FromQuery] GetNeighbourhoodsByDistrictIdQueryRequest request)
            => await DataResponse(request);
    }
}