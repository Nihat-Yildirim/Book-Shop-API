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
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByAuthorId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByBasketCount;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId;
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
        [CacheFilter(5, 1)]
        public async Task<IActionResult> GetAllBook([FromQuery] GetAllBookQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllBookForAdmin")]
        [CacheFilter(5, 1)]
        public async Task<IActionResult> GetAllBookForAdmin([FromQuery] GetAllBookForAdminQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetById")]
        [CacheFilter(2, 0.5)]
        public async Task<IActionResult> GetById([FromQuery] GetBookByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByNamePattern")]
        [CacheFilter(1, 0.5)]
        public async Task<IActionResult> GetBooksByNamePattern([FromQuery] GetBookByNamePatternQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByPublisherId")]
        [CacheFilter(2, 1)]
        public async Task<IActionResult> GetBooksByPublisherId([FromQuery] GetBooksByPublisherIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByAuthorId")]
        [CacheFilter(2, 1)]
        public async Task<IActionResult> GetBooksByAuthorId([FromQuery] GetBooksByAuthorIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBookByISBN")]
        [CacheFilter(2, 1)]
        public async Task<IActionResult> GetBookByISBN([FromQuery] GetBookByISBNQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByLanguageId")]
        [CacheFilter(1, 0.5)]
        public async Task<IActionResult> GetBooksByLanguageId([FromQuery] GetBooksByLanguageIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByCategoryId")]
        [CacheFilter(2, 1)]
        public async Task<IActionResult> GetBooksByCategoryId([FromQuery] GetBooksByCategoryIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByCommentCount")]
        [CacheFilter(1, 0.5)]
        public async Task<IActionResult> GetBooksByCommentCount([FromQuery] GetBooksByCommentCountQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByBasketCount")]
        [CacheFilter(1, 0.5)]
        public async Task<IActionResult> GetBooksByBasketCount([FromQuery] GetBooksByBasketCountQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetBooksByCategoryAndAuthorId")]
        [CacheFilter(2, 1)]
        public async Task<IActionResult> GetBooksByCategoryAndAuthorId([FromQuery(Name = "BookId")] int BookId, [FromQuery(Name = "CategoryIds[]")] int[] CategoryIds, [FromQuery(Name = "AuthorIds[]")] int[] AuthorIds)
        {
            GetBooksByCategoryAndAuthorIdQueryRequest request = new()
            {
                BookId = BookId,
                AuthorIds = AuthorIds,
                CategoryIds = CategoryIds,
            };

            return await DataResponse(request);
        }
    }
}