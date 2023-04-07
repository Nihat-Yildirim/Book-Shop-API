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
        ICustomerService _customerService;
        ICustomerAvatarService _customerAvatarService;
        public CustomersController(ICustomerService customerService, ICustomerAvatarService customerAvatarService, IUserService userService)
        {
            _customerService = customerService;
            _customerAvatarService = customerAvatarService;
            _userService = userService;
        }

        [HttpPost("updateavatar")]
        public IActionResult UpdateAvatar([FromForm(Name = "updatedcustomer")] CustomerForUpdateDto updatedCustomer,[FromForm(Name = "avatar")] IFormFile avatar) 
        {
            var resultUser = _userService.GetByMail(updatedCustomer.EMail);

            if (!resultUser.Success)
                return BadRequest("Kullanıcı bilgileri hatalı !!");

            if (!HashingHelper.VerifyPasswordHash(updatedCustomer.Password, resultUser.Data.PasswordHash, resultUser.Data.PasswordSalt))
                return BadRequest("Kullanıcı bilgikeri hatalı !!");

            var resultCustomer = _customerService.GetByUserId(resultUser.Data.Id).Data;
            
            _customerAvatarService.UpdateCustomerAvatar(avatar, resultCustomer);
            
            return Ok("Kullanıcı avatarı başarıyla güncellendi !!");
        }

        [HttpPost("delete")]
        public IActionResult Delete(CustomerForUpdateDto deletedCustomer)
        {
            var resultUpdatedUser = _userService.GetByMail(deletedCustomer.EMail);

            if (!resultUpdatedUser.Success)
                return BadRequest("Gerçekte böyle bir kullanıcı yok lütfen gerçek hesap bilgilerini giriniz !!");

            if (!HashingHelper.VerifyPasswordHash(deletedCustomer.Password, resultUpdatedUser.Data.PasswordHash, resultUpdatedUser.Data.PasswordSalt))
                return BadRequest("Kullanıcı şifresi yanlış lütfen silme işlemi gerçekleşmesi için şifrenizi doğru giriniz !!");

            var deletedUser = resultUpdatedUser.Data;
            deletedUser.Status = false;

            _userService.Update(deletedUser);
            return Ok();
        }
    }
}