using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("addauthor")]
        public IActionResult AddAuthor([FromForm(Name = "author")] Author author, [FromForm(Name = "athorPicture")] IFormFile authorPicture)
        {
            _authorService.Add(author, authorPicture);

            return Ok("Yazar başarıyla eklendi !");
        }

        [HttpPost("updateauthor")]
        public IActionResult UpdateAuthor([FromForm(Name = "author")] Author author, [FromForm(Name = "athorPicture")] IFormFile authorPicture)
        {
            _authorService.Update(author, authorPicture);

            return Ok("Yazar başarıyla güncellendi !");
        }

        [HttpGet("gettallauthor")]
        public IActionResult GetAllAuthor()
        {
            var resultAuthor = _authorService.GetAll().Data;

            return Ok(resultAuthor);
        }
    }
}