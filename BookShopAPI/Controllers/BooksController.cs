using AutoMapper;
using Business.Abstract;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Entities.Concrete;
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
        IStoreService _storeService;
        public BooksController
            (
            IMapper mapper,
            IBookService bookService,
            IBookPictureService bookPictureService,
            IBookOfCategoryService bookOfCategoryService,
            IStoreService storeService
            )
        {
            _mapper = mapper;
            _bookService = bookService;
            _storeService = storeService;
            _bookPictureService = bookPictureService;
            _bookOfCategoryService = bookOfCategoryService;
        }

        [HttpPost("addbook")]
        public IActionResult AddBook([FromForm(Name = "addedBook")] AddBookDto addedBook)
        {
            var addedBookResult = _bookService.Add(addedBook);

            if (!addedBookResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            var addedBookOfCategories = _mapper.Map<AddBookOfCategoryDto>(addedBook);
            addedBookOfCategories.BookId = addedBookResult.Data.Id;
            var addedBookOfCategoryResult = _bookOfCategoryService.Add(addedBookOfCategories);

            if (!addedBookOfCategoryResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            AddBookPictureDto addedBookPictures = new();
            addedBookPictures.BookPictures = addedBook.BookPictures;
            addedBookPictures.BookId = addedBookResult.Data.Id;
            var addedBookPicturesResult = _bookPictureService.Add(addedBookPictures);

            if (!addedBookPicturesResult.Success)
                return BadRequest("Ekleme işlemi başarısız oldu lütfen tekrar deneyiniz !");

            return Ok("Kitap ekleme işlemi başarıyla gerçekleştirildi !");
        }

        [HttpPost("updatebook")]
        public IActionResult UpdateBook(UpdateBookDto updatedBookDto)
        {
            _bookService.UpdateBook(updatedBookDto);

            return Ok("Kitap bilgileri başarıyla güncellendi !");
        }

        [HttpPost("updatebookpicture")]
        public IActionResult UpdateBookPicture([FromForm(Name = "updatedBookPicture")] UpdateBookPictureDto updatedBookPictureDto)
        {
            _bookPictureService.Update(updatedBookPictureDto);

            return Ok("Kitap resmi başarıyla güncellendi !");
        }

        [HttpPost("updatebookpictureorderofappearance")]
        public IActionResult UpdateBookPictureShow(UpdateBookPictureOrderOfAppearanceDto updateBookPictureOrderOfAppearance)
        {
            _bookPictureService.UpdateBookPictureOrderOfAppearance(updateBookPictureOrderOfAppearance);

            return Ok("Kitap resminin görünme sırası başarıyla güncellendi !");
        }

        [HttpPost("addbookpicture")]
        public IActionResult AddBookPicture([FromForm(Name = "addedBookPicture")] AddBookPictureDto addedBookPicture)
        {
            var resultBookPictureService = _bookPictureService.Add(addedBookPicture);

            if (!resultBookPictureService.Success)
                return BadRequest(resultBookPictureService.Message);

            return Ok("Kitap resmi başarıyla eklendi !");
        }

        [HttpGet("getallbook")]
        public IActionResult GetAllBook()
        {
            var resultBook = _bookService.GetAllBookDetail();

            return Ok(resultBook);
        }

        [HttpGet("getallstorebooks")]
        public IActionResult GetAllStoreBooks(int storeId)
        {
            var resultStore = _storeService.GetById(storeId);

            if (!resultStore.Success)
                return BadRequest("Mağazaya ait kitaplar getirilemedi");

            var resultBooks = _bookService.GetAllBookDetailByStoreName(resultStore.Data.Name);

            return Ok(resultBooks);
        }
    }
}