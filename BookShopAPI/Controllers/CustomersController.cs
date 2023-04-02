using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //TODO Kullanıcıya mantıklı hesap bilgileri güncelleme sistemi yaz
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
        public IActionResult UpdateAvatar([FromForm(Name = "id")] int customerId,[FromForm(Name = "avatar")] IFormFile avatar) 
        {
            var resultCustomer = _customerService.GetById(customerId);
            if(resultCustomer.Success)
            {
                var result = _customerAvatarService.UpdateCustomerAvatar(avatar,resultCustomer.Data);
                return Ok(result.Message);
            }
            return BadRequest("Kullanıcı avatarı güncellenemedi");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}