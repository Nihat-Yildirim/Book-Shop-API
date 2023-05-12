using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.CustomerDTOs;
using Entities.DTOs.DealerDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        IMapper _mapper;
        IAuthService _authService;
        IUserService _userService;
        IStoreService _storeService;
        IDealerService _dealerService;
        IUserAddressService _userAddressService;
        public DealerController(
            IMapper mapper,
            IAuthService authService, 
            IUserService userService,
            IStoreService storeService,
            IDealerService dealerService,
            IUserAddressService userAddressService)
        {
            _mapper = mapper;
            _authService = authService;
            _userService = userService;
            _storeService = storeService;
            _dealerService = dealerService;
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

        [HttpPost("delete")]
        public IActionResult Delete(UserForLoginDto loginDto)
        {
            var resultUser = _authService.Login(loginDto).Data;

            if (resultUser == null)
                return BadRequest("Lütfen Email ve Şifre değerlerini doğru giriniz !");

            var resultDealer = _dealerService.GetByUserId(resultUser.Id).Data;

            resultUser.Status = false;

            _userService.Update(resultUser);
            _storeService.Delete(resultDealer.StoreId);

            return Ok("Satıcı başarıyla silindi !");
        }

        [HttpPost("updateprofile")]
        public IActionResult UpdateProfile(DealerForUpdateDto profile)
        {
            _userService.Update(profile);
            return Ok("Kullanıcı bilgileri başarıyla güncellendi");
        }

        [HttpPost("adddealeraddress")]
        public IActionResult AddDealerAddress(AddDealerAddressDto addedDealerAdress)
        {
            var resultDealer = _dealerService.GetByDealerId(addedDealerAdress.DealerId).Data;

            if (resultDealer == null)
                return BadRequest("Kullanıcı adresi eklenemedi, lütfen parametreleri kontrol edin !");

            var address = _mapper.Map<UserAddress>(addedDealerAdress);
            address.UserId = resultDealer.UserId;
            address.Status = true;

            var result = _userAddressService.Add(address);

            return Ok(result);
        }

        [HttpPost("getalldealeraddress")]
        public IActionResult GetAllDealerAddress([FromForm(Name = "dealerId")] int dealerId)
        {
            var resultDealer = _dealerService.GetByDealerId(dealerId).Data;

            if (resultDealer == null)
                return BadRequest("Kullanıcı adresi getirilemedi, lütfen parametreleri kontrol edin !");

            var resultUserAddresses = _userAddressService.GetActiveUserAddressByUserId(resultDealer.UserId);

            return Ok(resultUserAddresses.Data);
        }

        [HttpPost("updatedealeraddress")]
        public IActionResult UpdateDealerAddress(UpdateDealerAddressDto updatedDealerAddress)
        {
            var resultDealer = _dealerService.GetByDealerId(updatedDealerAddress.DealerId).Data;

            if (resultDealer == null)
                return BadRequest("Kullanıcı adresi güncellenemedi, lütfen parametreleri kontrol edin !");

            var updatedAddress = _mapper.Map<UserAddress>(updatedDealerAddress);
            updatedAddress.UserId = resultDealer.UserId;
            updatedAddress.Status = true;

            _userAddressService.Update(updatedAddress);

            return Ok("Kullanıcı adresi başarıyla güncellendi !");
        }
    }
}