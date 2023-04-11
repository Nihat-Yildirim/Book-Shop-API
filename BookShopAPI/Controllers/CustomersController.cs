using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Entities.Concrete;
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
        ICustomerAvatarService _customerAvatarService;
        ICustomerService _customerService;
        public CustomersController(
            IUserService userService, 
            IAuthService authService, 
            ICustomerAvatarService customerAvatarService,
            ICustomerService customerService)
        {
            _userService = userService;
            _authService = authService;
            _customerAvatarService = customerAvatarService;
            _customerService = customerService;
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
            var resultCustomer = _customerService.GetByUserId(resultUser.Id).Data;
            
            resultUser.Status = false;

            _userService.Update(resultUser);
            _customerAvatarService.DeleteCustomerAvatar(resultCustomer.Id);

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