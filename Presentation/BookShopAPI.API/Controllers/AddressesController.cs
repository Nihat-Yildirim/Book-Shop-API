using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.DeleteAddress;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddress;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddressSelectedValue;
using BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAddressByUserAndAddressId;
using BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddress;
using BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddressByUserId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AddressesController : BaseController
    {
        public AddressesController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Customer")]
        [HttpPost]
        public async Task<IActionResult> AddAddress([FromQuery] AddAddressCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromQuery] UpdateAddressCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut("UpdateAddressSelectedValue")]
        public async Task<IActionResult> UpdateAddressSelectedValue([FromQuery] UpdateAddressSelectedValueCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress([FromQuery] DeleteAddressCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllAddress([FromQuery] GetAllAddressQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpGet("GetAllAddressByUserId")]
        public async Task<IActionResult> GetAllAddressByUserId([FromQuery] GetAllAddressByUserIdQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpGet("GetAddressByUserAndAddressId")]
        public async Task<IActionResult> GetAddressByUserAndAddressId([FromQuery] GetAddressByUserAndAddressIdQueryRequest request)
            => await DataResponse(request);
    }
}