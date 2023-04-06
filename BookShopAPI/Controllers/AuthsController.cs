using Business.Abstract;
using Core.Entities.Abstract;
using Core.Exceptions;
using Core.Exceptions.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        IAuthService _authService;
        ICustomerAvatarService _customerAvatarService;
        public AuthsController(IAuthService authService, ICustomerAvatarService customerAvatarService)
        {
            _authService = authService;
            _customerAvatarService = customerAvatarService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);

            if (!userToLogin.Success)
                return BadRequest("Hatalı mail adersi yada parola");

            var resultAccessToken = _authService.CreateAccessToken(userToLogin.Data);

            if (!resultAccessToken.Success)
                return BadRequest("Token Oluşturulamadı");

            return Ok(resultAccessToken.Data);
        }

        [HttpPost("customerregister")]
        public IActionResult CustomerRegister(CustomerForRegisterDto customerForRegisterDto)
        {
            var userExists = _authService.UserExists(customerForRegisterDto.Email);

            if (!userExists.Success)
                return BadRequest("Bu email adresine ait zaten aktif bir kullanıcı var !!");

            var registerResult = _authService.CustomerRegister(customerForRegisterDto);
            var resultAccessToken = _authService.CreateAccessToken(registerResult.Data);

            if (!resultAccessToken.Success)
                return BadRequest("Token Üretilemedi");

            return Ok(resultAccessToken.Data);
        }

        [HttpPost("dealerregister")]
        public IActionResult DealerRegister([FromForm(Name = "dealerforregister")] DealerForRegisterDto dealerForRegisterDto, [FromForm(Name = "logo")] IFormFile logo)
        {
            var userExists = _authService.UserExists(dealerForRegisterDto.Email);
            var storeExists = _authService.StoreExists(dealerForRegisterDto.StoreName);

            if (!userExists.Success)
                return BadRequest("Bu email adresine ait zaten aktif bir kullanıcı var !!");

            if (!storeExists.Success)
                return BadRequest("Bu mağaza ismine sahip zaten bir mağaza var !!");

            var registerResult = _authService.DealerRegister(dealerForRegisterDto,logo);
            var resultAccessToken = _authService.CreateAccessToken(registerResult.Data);

            if (!resultAccessToken.Success)
                return BadRequest("Tokan üretilemedi");

            return Ok(resultAccessToken.Data);
        }
    }
}