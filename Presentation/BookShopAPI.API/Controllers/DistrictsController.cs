using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.DistrictCommands.AddDistrict;
using BookShopAPI.Application.CQRS.Commands.DistrictCommands.DeleteDistrict;
using BookShopAPI.Application.CQRS.Commands.DistrictCommands.UpdateDistrict;
using BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetAllDistrict;
using BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictById;
using BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictsByProvinceId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class DistrictsController : BaseController
    {
        public DistrictsController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddDistrict")]
        public async Task<IActionResult> AddDistrict([FromQuery] AddDistrictCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateDistrict")]
        public async Task<IActionResult> UpdateDistrict([FromQuery] UpdateDistrictCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteDistrict")]
        public async Task<IActionResult> DeleteDistrict([FromQuery] DeleteDistrictCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAllDistrict")]
        [CacheFilter(72, 24)]
        public async Task<IActionResult> GetAllDistrict([FromQuery] GetAllDistrictQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetDistrictById")]
        [CacheFilter(24, 12)]
        public async Task<IActionResult> GetDistrictById([FromQuery] GetDistrictByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetDistrictsByProvinceId")]
        [CacheFilter(24, 12)]
        public async Task<IActionResult> GetDistrictsByProvinceId([FromQuery] GetDistrictsByProvinceIdQueryRequest request)
            => await DataResponse(request);
    }
}