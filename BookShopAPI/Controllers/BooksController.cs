using AutoMapper;
using Business.Abstract;
using Entities.DTOs.BookDTOs;
using Entities.DTOs.BookOfCategoryDTOs;
using Entities.DTOs.BookPictureDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IMapper _mapper;
        IBookService _bookService;
        IBookPictureService _bookPictureService;
        IBookOfCategoryService _bookOfCategoryService;
        public BooksController
            (
            IMapper mapper,
            IBookService bookService,
            IBookPictureService bookPictureService,
            IBookOfCategoryService bookOfCategoryService
            )
        {
            _mapper = mapper;
            _bookService = bookService;
            _bookPictureService = bookPictureService;
            _bookOfCategoryService = bookOfCategoryService;
        }

        [HttpPost("addbook")]
        public IActionResult AddBook([FromForm(Name = "addedBook")]AddedBookDto addedBook)
        {
            var addedBookResult = _bookService.Add(addedBook);

            if (!addedBookResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            var addedBookOfCategories = _mapper.Map<AddedBookOfCategoryDto>(addedBook);
            addedBookOfCategories.BookId = addedBookResult.Data.Id;
            var addedBookOfCategoryResult = _bookOfCategoryService.Add(addedBookOfCategories);

            if(!addedBookOfCategoryResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            AddedBookPictureDto addedBookPictures = new();
            addedBookPictures.BookPictures = addedBook.BookPictures;
            addedBookPictures.BookId = addedBookResult.Data.Id;
            var addedBookPicturesResult = _bookPictureService.Add(addedBookPictures);

            if (!addedBookPicturesResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            return Ok("Kitap ekleme işlemi başarıyla gerçekleştirildi !");
        }
    }
}
