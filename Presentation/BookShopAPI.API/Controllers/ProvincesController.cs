using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.AddProvince;
using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.DeleteProvince;
using BookShopAPI.Application.CQRS.Commands.ProvinceCommands.UpdateProvince;
using BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetAllProvince;
using BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetProvinceById;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class ProvincesController : BaseController
    {
        public ProvincesController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddProvince")]
        public async Task<IActionResult> AddProvince([FromQuery] AddProvinceCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateProvince")]
        public async Task<IActionResult> UpdateProvince([FromQuery] UpdateProvinceCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteProvince")]
        public async Task<IActionResult> DeleteProvince([FromQuery] DeleteProvinceCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAll")]
        [CacheFilter(25, 5)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProvinceQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetProvinceById")]
        [CacheFilter(25, 5)]
        public async Task<IActionResult> GetProvinceById([FromQuery] GetProvinceByIdQueryRequest request)
            => await DataResponse(request);
    }
}