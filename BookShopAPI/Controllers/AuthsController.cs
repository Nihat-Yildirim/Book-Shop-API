using Business.Abstract;
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

            var result = _authService.CreateCustomerAccessToken(customerToLogin.Data);

            if (!result.Success)
            {
                return BadRequest("Token Oluşturulamadı");
            }

            return Ok(result.Data);
        }

        [HttpPost("customerregister")]
        public IActionResult CustomerRegister(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.CustomerExists(userForRegisterDto.Email);

            if(!userExists.Success)
            {
                return BadRequest("Böyle bir kullanıcı zaten var");
            }

            var registerResult = _authService.CustomerRegister(userForRegisterDto);
            var accessTokenResult = _authService.CreateCustomerAccessToken(registerResult.Data);

            if(!accessTokenResult.Success)
            {
                return BadRequest("Token Üretilemedi");
            }
            return Ok(accessTokenResult.Data);
        }
    }
}