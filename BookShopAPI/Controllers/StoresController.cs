using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        IStoreService _storeService;
        IAuthService _authService;
        IDealerService _dealerService;
        public StoresController(IStoreService storeService,IAuthService authService,IDealerService dealerService)
        {
            _storeService= storeService;
            _authService= authService;
            _dealerService= dealerService;
        }

        [HttpPost("updatestorename")]
        public IActionResult UpdateStoreName([FromForm(Name = "logindto")] UserForLoginDto loginDto, [FromForm(Name = "newstorename")] string newStoreName)
        {
            var resultAuth = _authService.Login(loginDto);
            
            if (!resultAuth.Success)
                return BadRequest("Hatalı şifre veya e posta");

            var resultDealer = _dealerService.GetByUserId(resultAuth.Data.Id).Data;
            var result = _storeService.UpdateStoreName(resultDealer.StoreId, newStoreName);

            return Ok(result.Message);
        }   

        [HttpPost("updatestorelogo")]
        public IActionResult UpdateLogo([FromForm(Name ="storeId")] int storeId, [FromForm(Name = "logo")] IFormFile logo)
        {
            var resultStore = _storeService.GetById(storeId);
            _storeService.UpdateLogo(resultStore.Data,logo);

            return Ok("Mağaza logosu başarıyla güncellendi !");
        }

        [HttpPost("updatestoredescription")]
        public IActionResult UpdateStoreDescription([FromForm(Name = "storeId")] int storeId, [FromForm(Name = "description")]string description)
        {
            _storeService.UpdateStoreDescription(storeId, description);

            return Ok("Mağaza açıklaması başarıyla değiştirildi !");
        }
    }
}