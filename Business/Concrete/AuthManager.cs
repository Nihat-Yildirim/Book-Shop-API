using Business.Abstract;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IDealerService _dealerService;
        ICustomerService _customerService;
        IUserService _userService;
        ITokenHelper _tokenHelper;
        ICustomerAvatarService _customerAvatarService;
        public AuthManager(
            ICustomerService customerService, 
            ITokenHelper tokenHelper, 
            IDealerService dealerService,
            IUserService userService, 
            ICustomerAvatarService customerAvatarService)
        {
            _customerService = customerService;
            _userService = userService;
            _tokenHelper = tokenHelper;
            _dealerService = dealerService;
            _customerAvatarService = customerAvatarService;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var accessToken = _tokenHelper.CreateToken(user);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public IDataResult<User> CustomerRegister(CustomerForRegisterDto customerForRegisterDto)
        {
            var result = Register(customerForRegisterDto).Data;
            var customer = new Customer
            {
                UserId = result.Id
            };
            _customerService.Add(customer);
            _customerAvatarService.SetDefaultCustomerAvatar(customer);
            return new SuccessDataResult<User>(result);
        }

        public IResult UserExists(string email)
        {
            var resultUser = _userService.GetByMail(email);

            if (resultUser.Data != null)
                return new ErrorResult();

            return new SuccessResult();
        }

        private IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);

            var user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedDate = DateTime.Now,
                Status = true
            };
            _userService.Add(user);
            var resultUser = _userService.GetByMail(user.Email).Data;
            return new SuccessDataResult<User>(resultUser);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);

            if (!userToCheck.Success)
                return new ErrorDataResult<User>("Bu Email Adresine Kayıtlı Kullanıcı Bulunamadı");

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
                return new ErrorDataResult<User>("Şifre hatalı");

            return new SuccessDataResult<User>();
        }

        public IDataResult<User> DealerRegister(DealerForRegisterDto dealerForRegisterDto)
        {
            var result = Register(dealerForRegisterDto).Data;
            var dealer = new Dealer
            {
                UserId = result.Id
            };

            _dealerService.Add(dealer);
            return new SuccessDataResult<User>(result); 
        }
    }
}