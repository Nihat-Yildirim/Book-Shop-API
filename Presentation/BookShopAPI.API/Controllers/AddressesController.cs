using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Address.AddAddress;
using BookShopAPI.Application.CQRS.Commands.Address.DeleteAddress;
using BookShopAPI.Application.CQRS.Commands.Address.UpdateAddress;
using BookShopAPI.Application.CQRS.Queries.Address.GetAllAddress;
using BookShopAPI.Application.CQRS.Queries.Address.GetAllAddressByUserId;
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

        [AuthenticationFilter("User")]
        [HttpPost]
        public async Task<IActionResult> AddAddress([FromQuery] AddAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromQuery] UpdateAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress([FromQuery] DeleteAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("Admin")]
        [HttpGet]   
        public async Task<IActionResult> GetAllAddress([FromQuery] GetAllAddressQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpGet("GetAllAddressByUserId")]
        public async Task<IActionResult> GetAllAddressByUserId([FromQuery] GetAllAddressByUserIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}