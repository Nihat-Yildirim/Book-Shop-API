using Business.Abstract;
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
        ICustomerService _customerService;
        ITokenHelper _tokenHelper;
        IDealerService _dealerService;

        public AuthManager(ICustomerService customerService, ITokenHelper tokenHelper, IDealerService dealerService)
        {
            _customerService = customerService;
            _tokenHelper = tokenHelper;
            _dealerService = dealerService;
        }

        public IDataResult<AccessToken> CreateCustomerAccessToken(Customer customer)
        {
            var accessToken = _tokenHelper.CreateToken(customer);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public IDataResult<AccessToken> CreateDealerAccessToken(Dealer dealer)
        {
            var accessToken = _tokenHelper.CreateToken(dealer);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public IResult CustomerExists(string email)
        {
            if (!_customerService.GetByMail(email).Success)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<Customer> CustomerLogin(UserForLoginDto userForLoginDto)
        {
            var customerToCheck = _customerService.GetByMail(userForLoginDto.Email).Data;

            if(customerToCheck == null)
            {
                return new ErrorDataResult<Customer>();
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, customerToCheck.PasswordHash, customerToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Customer>();
            }

            return new SuccessDataResult<Customer>(customerToCheck);
        }

        public IDataResult<Customer> CustomerRegister(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash,passwordSalt;

            HashingHelper.CreatePasswordHash(userForRegisterDto.Password,out passwordHash,out passwordSalt);

            var customer = new Customer
            {
                FirstName= userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                PasswordHash= passwordHash,
                PasswordSalt= passwordSalt,
                CreatedDate= DateTime.Now,
                Status = true,
            };

            _customerService.Add(customer);
            return new SuccessDataResult<Customer>(customer);
        }

        public IResult DealerExists(string email)
        {
            if (!_dealerService.GetByMail(email).Success)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<Dealer> DealerLogin(UserForLoginDto userForLoginDto)
        {
            var dealerToCheck = _dealerService.GetByMail(userForLoginDto.Email).Data;

            if(dealerToCheck == null)
            {
                return new ErrorDataResult<Dealer>();
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, dealerToCheck.PasswordHash, dealerToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Dealer>();
            }
            return new SuccessDataResult<Dealer>(dealerToCheck);
        }

        public IDataResult<Dealer> DealerRegister(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);

            var dealer = new Dealer
            {
                FirstName= userForRegisterDto.FirstName,
                LastName= userForRegisterDto.LastName,
                Email= userForRegisterDto.Email,
                PasswordHash= passwordHash,
                PasswordSalt= passwordSalt,
                Status = true,
                CreatedDate = DateTime.Now,
            };

            _dealerService.Add(dealer);
            return new SuccessDataResult<Dealer>(dealer);
        }
    }
}