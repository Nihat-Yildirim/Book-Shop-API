using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.DeleteAddress;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddress;
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

        [AuthorizationFilter("Customer")]
        [HttpPost]
        public async Task<IActionResult> AddAddress([FromQuery] AddAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Customer")]
        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromQuery] UpdateAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Customer")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress([FromQuery] DeleteAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]   
        public async Task<IActionResult> GetAllAddress([FromQuery] GetAllAddressQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthorizationFilter("Customer")]
        [HttpGet("GetAllAddressByUserId")]
        public async Task<IActionResult> GetAllAddressByUserId([FromQuery] GetAllAddressByUserIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}