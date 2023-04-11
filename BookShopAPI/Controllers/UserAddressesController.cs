using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressesController : ControllerBase
    {
        IUserAddressService _userAddressService;

        public UserAddressesController(IUserAddressService userAddressService)
        {
            _userAddressService = userAddressService;
        }

        [HttpPost("adduseraddress")]
        public IActionResult AddUserAddress(UserAddress userAddress)
        {
            _userAddressService.Add(userAddress);

            return Ok("Kullanıcı adresi başarıyla eklendi !");
        }

        [HttpPost("updateuseraddress")]
        public IActionResult UpdateUserAddress(UserAddress userAddress) 
        {
            _userAddressService.Update(userAddress);

            return Ok("Kullanıcı adresi başarıyla güncellendi !");
        }

        [HttpPost("deleteuseraddress")]
        public IActionResult DeleteUserAddress(UserAddress userAddress)
        {
            userAddress.Status = false;

            _userAddressService.Update(userAddress);

            return Ok("Kullanıcı adresi başarıyla silindi !");
        }

        [HttpGet("getactiveuseraddresses")]
        public IActionResult GetActiveUserAddresses([FromForm(Name = "userId")] int userId)
        {
            var resultUserAddresses = _userAddressService.GetActiveUserAddressByUserId(userId);

            return Ok(resultUserAddresses.Data);
        }
    }
}