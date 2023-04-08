using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        IAuthService _authService;
        IUserService _userService;
        IStoreService _storeService;
        IDealerService _dealerService;
        public DealerController(
            IAuthService authService, 
            IUserService userService, 
            IStoreService storeService, 
            IDealerService dealerService)
        {
            _authService = authService;
            _userService = userService;
            _storeService = storeService;
            _dealerService = dealerService;
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
        public IActionResult Delete(UserForLoginDto loginDto)
        {
            var resultUser = _authService.Login(loginDto).Data;

            if (resultUser == null)
                return BadRequest("Lütfen Email ve Şifre değerlerini doğru giriniz !");

            var resultDealer = _dealerService.GetByUserId(resultUser.Id).Data;

            _userService.Delete(resultUser);
            _storeService.Delete(resultDealer.StoreId);

            return Ok("Satıcı başarıyla silindi !");
        }

        [HttpPost("updateprofile")]
        public IActionResult UpdateProfile(DealerForUpdateDto profile)
        {
            _userService.Update(profile);
            return Ok("Kullanıcı bilgileri başarıyla güncellendi");
        }
    }
}