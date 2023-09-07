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
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByLanguageId;
using BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class BooksController : BaseController
    {
        public BooksController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("AddBook")]
        public async Task<IActionResult> AddBook([FromQuery] AddBookCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPost("AddBookPictures")]
        public async Task<IActionResult> AddBookPictures([FromForm] AddBookPicturesCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateBook")]
        public async Task<IActionResult> UpdateBook([FromQuery] UpdateBookCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateBookAuthors")]
        public async Task<IActionResult> UpdateBookAuthors([FromQuery] UpdateBookAuthorsCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateBookCategories")]
        public async Task<IActionResult> UpdateBookCategories([FromQuery] UpdateBookCategoriesCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateBookPicture")]
        public async Task<IActionResult> UpdateBookPicture([FromForm] UpdateBookPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeleteBook")]
        public async Task<IActionResult> DeleteBook([FromQuery] DeleteBookCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeleteBookPicture")]
        public async Task<IActionResult> DeleteBookPicture([FromQuery] DeleteBookPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet("GetAllBook")]
        public async Task<IActionResult> GetAllBook([FromQuery] GetAllBookQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetAllBookForAdmin")]
        public async Task<IActionResult> GetAllBookForAdmin([FromQuery] GetAllBookForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetBookByIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetByIdForAdmin")]
        public async Task<IActionResult> GetByIdForAdmin([FromQuery] GetBookForAdminByIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByNamePattern")]
        public async Task<IActionResult> GetBooksByNamePattern([FromQuery] GetBookByNamePatternQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByNamePatternForAdmin")]
        public async Task<IActionResult> GetBooksByNamePatternForAdmin([FromQuery] GetBookByNamePatternForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByPublisherId")]
        public async Task<IActionResult> GetBooksByPublisherId([FromQuery] GetBooksByPublisherIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByAuthorId")]
        public async Task<IActionResult> GetBooksByAuthorId([FromQuery] GetBooksByAuthorIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBookByISBN")]
        public async Task<IActionResult> GetBookByISBN([FromQuery] GetBookByISBNQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByLanguageId")]
        public async Task<IActionResult> GetBooksByLanguageId([FromQuery] GetBooksByLanguageIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetBooksByCategoryId")]
        public async Task<IActionResult> GetBooksByCategoryId([FromQuery] GetBooksByCategoryIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}