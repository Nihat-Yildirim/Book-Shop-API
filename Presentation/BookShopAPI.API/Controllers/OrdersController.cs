using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.OrderCommands.AddOrder;
using BookShopAPI.Application.CQRS.Commands.OrderCommands.UpdateOrder;
using BookShopAPI.Application.CQRS.Queries.OrderQueries.GetAllOrder;
using BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrdersByUserId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class OrdersController : BaseController
    {
        public OrdersController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Customer")]
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder([FromQuery] AddOrderCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder([FromQuery] UpdateOrderCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllOrder")]
        public async Task<IActionResult> GetAllOrder([FromQuery] GetAllOrderQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpGet("GetOrdersByUserId")]
        public async Task<IActionResult> GetOrdersByUserId([FromQuery] GetOrdersByUserIdQueryRequest request)
            => await DataResponse(request);
    }
}