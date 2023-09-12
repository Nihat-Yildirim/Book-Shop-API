using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.AddPhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.DeletePhoneNumber;
using BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.UpdatePhoneNumber;
using BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetAllPhoneNumbers;
using BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetPhoneNumbersByUserId;
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

        //[AuthorizationFilter("Customer")]
        [HttpPost]
        public async Task<IActionResult> AddPhoneNumber([FromQuery] AddPhoneNumberCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut]
        public async Task<IActionResult> UpdatePhoneNumber([FromQuery] UpdatePhoneNumberCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpDelete]
        public async Task<IActionResult> DeletePhoneNumber([FromQuery] DeletePhoneNumberCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllPhoneNumbers([FromQuery] GetAllPhoneNumbersQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpGet("GetUserPhoneNumbers")]
        public async Task<IActionResult> GetUserPhoneNumbers([FromQuery] GetPhoneNumbersByUserIdQueryRequest request)
            => await DataResponse(request);
    }
}