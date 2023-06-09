﻿using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> Add(User user);
        IDataResult<User> GetByMail(string mail);
        IDataResult<User> GetById(int Id);
        IDataResult<List<Claim>> GetClaims(User user);
        IResult Update(UserForUpdateDto userForUpdateDto);
        IResult Update(User user);
        IResult UpdatePassword(User user, string password);
    }
}