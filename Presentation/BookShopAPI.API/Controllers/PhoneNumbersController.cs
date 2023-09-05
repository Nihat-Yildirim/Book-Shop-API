using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.AddPhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.DeletePhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.UpdatePhoneNumber;
using BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetAllPhoneNumbers;
using BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetPhoneNumbersByUserId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class PhoneNumbersController : BaseController
    {
        public PhoneNumbersController(IMediator mediator) : base(mediator)
        {
        }

        [AuthenticationFilter("User")]
        [HttpPost]
        public async Task<IActionResult> AddPhoneNumber([FromQuery] AddPhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpPut]
        public async Task<IActionResult> UpdatePhoneNumber([FromQuery] UpdatePhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpDelete]
        public async Task<IActionResult> DeletePhoneNumber([FromQuery] DeletePhoneNumberCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthenticationFilter("Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllPhoneNumbers([FromQuery] GetAllPhoneNumbersQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthenticationFilter("User")]
        [HttpGet("GetUserPhoneNumbers")]
        public async Task<IActionResult> GetUserPhoneNumbers([FromQuery] GetPhoneNumbersByUserIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}