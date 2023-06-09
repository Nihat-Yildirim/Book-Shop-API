﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using Entities.DTOs.CustomerDTOs;
using Entities.DTOs.DealerDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult UserExists(string email);
        IResult StoreExists(string storeName);
        IDataResult<User> CustomerRegister(CustomerForRegisterDto customerForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> DealerRegister(DealerForRegisterDto dealerForRegisterDto, IFormFile formFile);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}