using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        ICustomerAvatarService _customerAvatarService;
        public CustomersController(ICustomerService customerService, ICustomerAvatarService customerAvatarService)
        {
            _customerService = customerService;
            _customerAvatarService = customerAvatarService;
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
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