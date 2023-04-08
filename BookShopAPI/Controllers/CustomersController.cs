using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        IUserService _userService;
        IAuthService _authService;
        public CustomersController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("updatepassword")]
        public IActionResult UpdatePassword([FromForm(Name = "userForLoginDto")] UserForLoginDto userForLoginDto, [FromForm(Name = "newPassword")] string newPassword)
        {
            var resultUser = _authService.Login(userForLoginDto);

            if (!resultUser.Success)
                return BadRequest("Lütfen önceki şifre değerini doğru giriniz !");

            _userService.UpdatePassword(resultUser.Data, newPassword);
            return Ok("Kullanıcı şifresi başarıyle güncellendi !");
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name ="email")] string email)
        {
            var resultUser = _userService.GetByMail(email).Data;
            _userService.Delete(resultUser);

            return Ok("Kullanıcı başarıyla silindi !");
        }

        [HttpPost("updateprofile")]
        public IActionResult UpdateProfile(CustomerForUpdateDto profile) 
        {
            _userService.Update(profile);
            return Ok("Kullanıcı bilgileri başarıyla güncellendi");
        }
    }
}