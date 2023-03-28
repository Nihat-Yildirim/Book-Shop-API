using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Customer> CustomerRegister(UserForRegisterDto userForRegisterDto);
        IDataResult<Customer> CustomerLogin(UserForLoginDto userForLoginDto);
        IResult CustomerExists(string email);
        IDataResult<AccessToken> CreateCustomerAccessToken(Customer customer);
    }
}