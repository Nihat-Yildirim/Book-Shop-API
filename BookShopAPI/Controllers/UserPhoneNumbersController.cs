using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPhoneNumbersController : ControllerBase
    {
        IUserPhoneNumberService _userPhoneNumberService;
        public UserPhoneNumbersController(IUserPhoneNumberService userPhoneNumberService)
        {
            _userPhoneNumberService = userPhoneNumberService;
        }

        [HttpPost("adduserphonenumber")]
        public IActionResult AddUserPhoneNumber(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberService.Add(userPhoneNumber);

            return Ok("Kullanıcıya başarıyla numara eklendi !");
        }

        [HttpPost("deleteuserphonenumber")]
        public IActionResult DeleteUserPhoneNumber(UserPhoneNumber userPhoneNumber)
        {
            userPhoneNumber.Status = false;

            _userPhoneNumberService.Update(userPhoneNumber);

            return Ok("Kullanıcı numarası başarıyla silindi !");
        }

        [HttpPost("updateuserphonenumber")]
        public IActionResult UpdateUserPhoneNumber(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberService.Update(userPhoneNumber);

            return Ok("Kullanıcı numarası başarıyla güncellendi !");
        }

        [HttpGet("getactiveuserphonenumbers")]
        public IActionResult GetActiveUserPhoneNumbers([FromForm(Name = "userId")] int userId)
        {
            var resultUserPhoneNumber = _userPhoneNumberService.GetActiveUserPhoneNumbers(userId);

            return Ok(resultUserPhoneNumber.Data);
        }
    }
}