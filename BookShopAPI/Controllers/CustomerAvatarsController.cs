using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAvatarsController : ControllerBase
    {
        ICustomerAvatarService _customerAvatarService;
        public CustomerAvatarsController(ICustomerAvatarService customerAvatarService)
        {
            _customerAvatarService = customerAvatarService;
        }

        [HttpPost("updatecustomeravatar")]
        public IActionResult UpdateCustomerAvatar([FromForm(Name = "customerId")] int customerId, [FromForm(Name ="avatar")] IFormFile avatar)
        {
            var resultCustomerAvatar = _customerAvatarService.GetByCustomerId(customerId);

            if (resultCustomerAvatar.Data == null)
                _customerAvatarService.AddCustomerAvatar(avatar, customerId);
            else
                _customerAvatarService.UpdateCustomerAvatar(avatar, customerId);    
            
            return Ok("Kullanıcının avatar resmi başarıyla güncellendi");
        }

        [HttpPost("deletecustomeravatar")]
        public IActionResult DeleteCustomerAvatar([FromForm(Name = "customerId")] int customerId)
        {
            _customerAvatarService.DeleteCustomerAvatar(customerId);
            
            return Ok("Kullanıcı avatarı başarıyla silindi !");
        }
    }
}
