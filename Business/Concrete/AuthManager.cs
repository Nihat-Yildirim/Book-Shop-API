using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.CustomerDTOs;
using Entities.DTOs.DealerDTOs;
using Microsoft.AspNetCore.Http;
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
        IStoreService _storeService;
        public AuthManager(
            ICustomerService customerService, 
            ITokenHelper tokenHelper, 
            IDealerService dealerService,
            IUserService userService, 
            IStoreService storeService)
        {
            _customerService = customerService;
            _userService = userService;
            _tokenHelper = tokenHelper;
            _dealerService = dealerService;
            _storeService= storeService;    
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var accessToken = _tokenHelper.CreateToken(user);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        [ValidationAspect(typeof(CustomerForRegisterDtoValidator))]
        public IDataResult<User> CustomerRegister(CustomerForRegisterDto customerForRegisterDto)
        {
            var result = Register(customerForRegisterDto).Data;
            var customer = new Customer
            {
                UserId = result.Id
            };
            _customerService.Add(customer);
            return new SuccessDataResult<User>(result);
        }


        [ValidationAspect(typeof(UserForLoginDtoValidator))]
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);

            if (!userToCheck.Success)
                return new ErrorDataResult<User>("Bu Email Adresine Kayıtlı Kullanıcı Bulunamadı");

            if (userToCheck.Data.Status == false)
                return new ErrorDataResult<User>("Böyle bir kullanıcı yok !");

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
                return new ErrorDataResult<User>("Şifre hatalı");

            return new SuccessDataResult<User>(userToCheck.Data);
        }

        [ValidationAspect(typeof(DealerForRegisterDtoValidator))]
        public IDataResult<User> DealerRegister(DealerForRegisterDto dealerForRegisterDto,IFormFile formFile)
        {
            var resultUser = Register(dealerForRegisterDto).Data;
            var store = new Store
            {
                Name = dealerForRegisterDto.StoreName,
                Description = dealerForRegisterDto.StoreDescription,
            };

            _storeService.Add(store,formFile);
            var resultStore = _storeService.GetByStoreName(store.Name).Data;

            var dealer = new Dealer
            {
                StoreId = resultStore.Id,
                UserId = resultUser.Id,
            };

            _dealerService.Add(dealer);
            return new SuccessDataResult<User>(resultUser); 
        }

        public IResult StoreExists(string storeName)
        {
            var resultStore = _storeService.CheckStoreNameExists(storeName);

            if (resultStore.Success == true)
                return new SuccessResult();
            
            return new ErrorResult();
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
        public IResult UserExists(string email)
        {
            var resultUser = _userService.GetByMail(email);

            if (resultUser.Data != null)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}