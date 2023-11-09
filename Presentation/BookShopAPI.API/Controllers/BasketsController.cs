using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasket;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasketItem;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.DeleteBasketItem;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItem;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItemSelectedValue;
using BookShopAPI.Application.CQRS.Queries.BasketQueries.GetAllBasket;
using BookShopAPI.Application.CQRS.Queries.BasketQueries.GetBasketByUserId;
using BookShopAPI.Application.CQRS.Queries.BasketQueries.GetSelectedBookBasketCount;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class BasketsController : BaseController
    {
        public BasketsController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Customer")]
        [HttpPost("AddBasket")]
        public async Task<IActionResult> AddBasket([FromQuery] AddBasketCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPost("AddBasketItem")]
        public async Task<IActionResult> AddBasketItem([FromQuery] AddBasketItemCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut("UpdateBasketItem")]
        public async Task<IActionResult> UpdateBasketItem([FromQuery] UpdateBasketItemCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut("UpdateBasketItemSelectedValue")]
        public async Task<IActionResult> UpdateBasketItemSelectedValue([FromQuery] UpdateBasketItemSelectedValueCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpDelete("DeleteBasketItem")]
        public async Task<IActionResult> DeleteBasketItem([FromQuery] DeleteBasketItemCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllBasket")]
        public async Task<IActionResult> GetAllBasket([FromQuery] GetAllBasketQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpGet("GetBasketByUserId")]
        public async Task<IActionResult> GetBasketByUserId([FromQuery] GetBasketByUserIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetSelectedBookBasketCount")]
        public async Task<IActionResult> GetSelectedBookBasketCount([FromQuery] GetSelectedBookBasketCountQueryRequest request)
            => await DataResponse(request);
    }
}