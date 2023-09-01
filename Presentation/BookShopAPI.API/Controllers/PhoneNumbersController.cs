using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.AddPhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.DeletePhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.UpdatePhoneNumber;
using BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetAllPhoneNumbers;
using BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetPhoneNumbersByUserId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class PhoneNumbersController : BaseController
    {
        public PhoneNumbersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddPhoneNumber([FromQuery] AddPhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePhoneNumber([FromQuery] UpdatePhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePhoneNumber([FromQuery] DeletePhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPhoneNumbers([FromQuery] GetAllPhoneNumbersQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetUserPhoneNumbers")]
        public async Task<IActionResult> GetUserPhoneNumbers([FromQuery] GetPhoneNumbersByUserIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}