using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.BookCommands.AddBook;
using BookShopAPI.Application.CQRS.Commands.BookCommands.AddBookPictures;
using BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBook;
using BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBookPicture;
using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBook;
using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookAuthors;
using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookCategories;
using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookPicture;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBook;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBookForAdmin;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookById;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByISBN;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePattern;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePatternForAdmin;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookForAdminById;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByAuthorId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByBasketCount;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCommentCount;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByLanguageId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class BooksController : BaseController
    {
        public BooksController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddBook")]
        public async Task<IActionResult> AddBook([FromQuery] AddBookCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddBookPictures")]
        public async Task<IActionResult> AddBookPictures([FromForm] AddBookPicturesCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateBook")]
        public async Task<IActionResult> UpdateBook([FromQuery] UpdateBookCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateBookAuthors")]
        public async Task<IActionResult> UpdateBookAuthors([FromQuery] UpdateBookAuthorsCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateBookCategories")]
        public async Task<IActionResult> UpdateBookCategories([FromQuery] UpdateBookCategoriesCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateBookPicture")]
        public async Task<IActionResult> UpdateBookPicture([FromForm] UpdateBookPictureCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteBook")]
        public async Task<IActionResult> DeleteBook([FromQuery] DeleteBookCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteBookPicture")]
        public async Task<IActionResult> DeleteBookPicture([FromQuery] DeleteBookPictureCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAllBook")]
        public async Task<IActionResult> GetAllBook([FromQuery] GetAllBookQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllBookForAdmin")]
        public async Task<IActionResult> GetAllBookForAdmin([FromQuery] GetAllBookForAdminQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetBookByIdQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetByIdForAdmin")]
        public async Task<IActionResult> GetByIdForAdmin([FromQuery] GetBookForAdminByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByNamePattern")]
        public async Task<IActionResult> GetBooksByNamePattern([FromQuery] GetBookByNamePatternQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetBooksByNamePatternForAdmin")]
        public async Task<IActionResult> GetBooksByNamePatternForAdmin([FromQuery] GetBookByNamePatternForAdminQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByPublisherId")]
        public async Task<IActionResult> GetBooksByPublisherId([FromQuery] GetBooksByPublisherIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByAuthorId")]
        public async Task<IActionResult> GetBooksByAuthorId([FromQuery] GetBooksByAuthorIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBookByISBN")]
        public async Task<IActionResult> GetBookByISBN([FromQuery] GetBookByISBNQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByLanguageId")]
        public async Task<IActionResult> GetBooksByLanguageId([FromQuery] GetBooksByLanguageIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByCategoryId")]
        public async Task<IActionResult> GetBooksByCategoryId([FromQuery] GetBooksByCategoryIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByCommentCount")]
        public async Task<IActionResult> GetBooksByCommentCount([FromQuery] GetBooksByCommentCountQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByBasketCount")]
        public async Task<IActionResult> GetBooksByBasketCount([FromQuery] GetBooksByBasketCountQueryRequest request)
            => await DataResponse(request);
    }
}