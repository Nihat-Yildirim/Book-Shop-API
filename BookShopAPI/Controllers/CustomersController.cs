using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.CustomerDTOs;
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
        ICustomerService _customerService;
        IUserAddressService _userAddressService;
        public CustomersController(
            IUserService userService,
            IAuthService authService,
            ICustomerService customerService,
            IUserAddressService userAddressService)
        {
            _userService = userService;
            _authService = authService;
            _customerService = customerService;
            _userAddressService = userAddressService;
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

        [HttpPost("getcustomerprofile")]
        public IActionResult GetCustomerProfile([FromForm(Name = "customerId")] int customerId)
        {
            var resultCustomerProfile = _customerService.GetCustomerDetailById(customerId);

            return Ok(resultCustomerProfile);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = "email")] string email)
        {
            var resultUser = _userService.GetByMail(email).Data;
            var resultCustomer = _customerService.GetByUserId(resultUser.Id).Data;

            resultUser.Status = false;

            _userService.Update(resultUser);
            _customerService.DeleteCustomerAvatar(resultCustomer.Id);

            return Ok("Kullanıcı başarıyla silindi !");
        }

        [HttpPost("updateprofile")]
        public IActionResult UpdateProfile(CustomerForUpdateDto profile)
        {
            _userService.Update(profile);
            return Ok("Kullanıcı bilgileri başarıyla güncellendi");
        }

        [HttpPost("updatecustomeravatar")]
        public IActionResult UpdateCustomerAvatar([FromForm(Name = "customerId")] int customerId, [FromForm(Name = "avatar")] IFormFile avatar)
        {
            var resultCustomer = _customerService.GetCustomerById(customerId).Data;

            if (resultCustomer.FileId == default)
                _customerService.AddCustomerAvatar(customerId, avatar);
            else
                _customerService.UpdateCustomerAvatar(customerId, avatar);

            return Ok("Kullanıcının avatar resmi başarıyla güncellendi");
        }

        [HttpPost("deletecustomeravatar")]
        public IActionResult DeleteCustomerAvatar([FromForm(Name = "customerId")] int customerId)
        {
            _customerService.DeleteCustomerAvatar(customerId);

            return Ok("Kullanıcı avatarı başarıyla silindi !");
        }

        [HttpPost("addcustomeraddress")]
        public IActionResult AddCustomerAddress(AddedCustomerAdressDto addedCustomerAdress)
        {
            var resultCustomer = _customerService.GetCustomerById(addedCustomerAdress.CustomerId).Data;

            if (resultCustomer == null)
                return BadRequest("Kullanıcı adresi eklenemedi, lütfen parametreleri kontrol edin !");

            var address = new UserAddress
            {
                UserId = resultCustomer.UserId,
                Province = addedCustomerAdress.Province,
                District = addedCustomerAdress.District,
                Address = addedCustomerAdress.Address,
                AddressTitle = addedCustomerAdress.AddressTitle,
                Neighbourhood = addedCustomerAdress.Neighbourhood,
                Description = addedCustomerAdress.Description,
                Status = true
            };

            var result = _userAddressService.Add(address);

            return Ok(result);
        }

        [HttpPost("getallcustomeraddress")]
        public IActionResult GetAllCustomerAddress([FromForm(Name = "customerId")] int customerId)
        {
            var resultCustomer = _customerService.GetCustomerById(customerId).Data;

            if (resultCustomer == null)
                return BadRequest("Kullanıcı adresi getirilemedi, lütfen parametreleri kontrol edin !");

            var resultUserAddresses = _userAddressService.GetActiveUserAddressByUserId(resultCustomer.UserId);

            return Ok(resultUserAddresses.Data);
        }

        [HttpPost("updatecustomeraddress")]
        public IActionResult UpdateCustomerAddress(UpdatedCustomerAddressDto updatedCustomerAddress)
        {
            var resultCustomer = _customerService.GetCustomerById(updatedCustomerAddress.CustomerId).Data;

            if (resultCustomer == null)
                return BadRequest("Kullanıcı adresi güncellenemedi, lütfen parametreleri kontrol edin !");

            var updatedAddress = new UserAddress
            {
                Id = updatedCustomerAddress.AddressId,
                UserId = resultCustomer.UserId,
                Address = updatedCustomerAddress.Address,
                AddressTitle = updatedCustomerAddress.AddressTitle,
                Description = updatedCustomerAddress.Description,
                District = updatedCustomerAddress.District,
                Neighbourhood = updatedCustomerAddress.Neighbourhood,
                Province = updatedCustomerAddress.Province,
                Status = true
            };

            _userAddressService.Update(updatedAddress);

            return Ok("Kullanıcı adresi başarıyla güncellendi !");
        }
    }
}