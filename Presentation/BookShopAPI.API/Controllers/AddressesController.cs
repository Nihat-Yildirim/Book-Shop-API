using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Address.AddAddress;
using BookShopAPI.Application.CQRS.Commands.Address.DeleteAddress;
using BookShopAPI.Application.CQRS.Commands.Address.UpdateAddress;
using BookShopAPI.Application.CQRS.Queries.Address.GetAllAddress;
using BookShopAPI.Application.CQRS.Queries.Address.GetAllAddressByUserId;
using BookShopAPI.Application.DTOs.AddressDTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AddressesController : BaseController
    {
        public AddressesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress([FromQuery] AddAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromQuery] UpdateAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAddress([FromQuery] DeleteAddressCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet]   
        public async Task<IActionResult> GetAllAddress([FromQuery] GetAllAddressQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetAllAddressByUserId")]
        public async Task<IActionResult> GetAllAddressByUserId([FromQuery] GetAllAddressByUserIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}