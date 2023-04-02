using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal= userDal;
        }

        public IDataResult<User> Add(User user)
        {
            _userDal.Add(user);
            return new SuccessDataResult<User>();
        }

        public IDataResult<User> GetByMail(string mail)
        {
            var resultUser = _userDal.Get(u => u.Email == mail);
            return new SuccessDataResult<User>(resultUser); 
        }
    }
}