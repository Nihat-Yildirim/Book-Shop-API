using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.AddFavoriteBook;
using BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.DeleteFavoriteBook;
using BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetSelectedBookFavoriteDatasForDays;
using BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetUserFavoriteBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class FavoriteBooksController : BaseController
    {
        public FavoriteBooksController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("AddFavoriteBook")]
        public async Task<IActionResult> AddFavoriteBook([FromQuery] AddFavoriteBookCommandRequest request)
            => await DataResponse(request);

        [HttpDelete("DeleteFavoriteBook")]
        public async Task<IActionResult> DeleteFavoriteBook([FromQuery] DeleteFavoriteBookCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetUserFavoriteBooks")]
        public async Task<IActionResult> GetUserFavoriteBooks([FromQuery] GetUserFavoriteBooksQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetSelectedBookFavoriteDatasForDays")]
        public async Task<IActionResult> GetSelectedBookFavoriteDatasForDays([FromQuery] GetSelectedBookFavoriteDatasForDaysQueryRequest request)
            => await DataResponse(request);
    }
}
