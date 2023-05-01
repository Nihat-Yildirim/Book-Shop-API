using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Concrete;
using System.Net;
using Core.Utilities.Helpers.FileAddressHelper;
using Entities.DTOs.PublisherDTOs;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        IPublisherService _publisherService;
        public PublishersController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("addpublisher")]
        public IActionResult AddPublisher([FromForm(Name = "addedPublisher")] AddedPublisherDto addedPublisher)
        {
            _publisherService.Add(addedPublisher);

            return Ok("Yayıncı başarıyla eklendi !");
        }

        [HttpPost("updatepublisher")]
        public IActionResult UpdatePublisher([FromForm(Name ="updatedPublisher")] UpdatedPublisherDto updatedPublisher)
        {
            _publisherService.Update(updatedPublisher);

            return Ok("Yayıncı başarıyla güncellendi !");
        }

        [HttpGet("getallpublisher")]
        public IActionResult GetAllPublisher()
        {
            var resultPublisher = _publisherService.GetAll();

            return Ok(resultPublisher);
        }
        
    }
}
