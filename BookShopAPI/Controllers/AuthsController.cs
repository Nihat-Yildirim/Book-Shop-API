using Business.Abstract;
using Business.FileHelpers.Concrete;
using Core.Entities.Abstract;
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
        public AuthsController(IAuthService authService)
        {
            _authService= authService;
        }

        [HttpPost("customerlogin")]
        public IActionResult CustomerLogin(UserForLoginDto userForLoginDto)
        {
            var customerToLogin = _authService.CustomerLogin(userForLoginDto);

            if (!customerToLogin.Success)
            {
                return BadRequest("Hatalı mail adersi yada parola");
            }

            var resultAccessToken = _authService.CreateCustomerAccessToken(customerToLogin.Data);

            if (!resultAccessToken.Success)
            {
                return BadRequest("Token Oluşturulamadı");
            }

            return Ok(resultAccessToken.Data);
        }

        [HttpPost("customerregister")]
        public IActionResult CustomerRegister(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.CustomerExists(userForRegisterDto.Email);

            if(!userExists.Success)
            {
                return BadRequest("Bu email adresine ait zaten aktif bir kullanıcı var !!");
            }

            var registerResult = _authService.CustomerRegister(userForRegisterDto);
            var resultAccessToken = _authService.CreateCustomerAccessToken(registerResult.Data);

            if(!resultAccessToken.Success)
            {
                return BadRequest("Token Üretilemedi");
            }
            return Ok(resultAccessToken.Data);
        }

        [HttpPost("dealerlogin")]
        public IActionResult DealerLogin(UserForLoginDto userForLoginDto)
        {
            var dealerLogin = _authService.DealerLogin(userForLoginDto);

            if(!dealerLogin.Success)
            {
                return BadRequest("Hatalı Email veya parola");
            }

            var resultAccessToken = _authService.CreateDealerAccessToken(dealerLogin.Data);
            
            if(!resultAccessToken.Success)
            {
                return BadRequest("Tokan üretilemedi");
            }
            return Ok(resultAccessToken.Data);
        }

        [HttpPost("dealerregister")]
        public IActionResult DealerRegister(UserForRegisterDto userForRegisterDto)
        {
            var dealerExists = _authService.DealerExists(userForRegisterDto.Email);

            if(!dealerExists.Success)
            {
                return BadRequest("Bu email adresine ait zaten aktif bir kullanıcı var !!");
            }

            var registerResult = _authService.DealerRegister(userForRegisterDto);
            var resultAccessToken = _authService.CreateDealerAccessToken(registerResult.Data);

            if(!resultAccessToken.Success)
            {
                return BadRequest("Tokan üretilemedi");
            }
            return Ok(resultAccessToken.Data);
        }

        [HttpGet("delete")]
        public IActionResult Delete()
        {
            CustomerAvatarFileService customerAvatarFileService = new CustomerAvatarFileService();
            customerAvatarFileService.DeleteCustomerAvatar("3110b310-0aa6-48d5-88f3-0144dc3b5e41.png");
            return Ok();
        }
    }
}