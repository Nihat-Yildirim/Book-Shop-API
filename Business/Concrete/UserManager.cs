using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
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

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult();
        }

        public IDataResult<User> GetById(int Id)
        {
            var resultUser = _userDal.Get(u => u.Id == Id);
            return new SuccessDataResult<User>(resultUser); 
        }

        public IDataResult<User> GetByMail(string mail)
        {
            var resultUser = _userDal.Get(u => u.Email == mail);
            return new SuccessDataResult<User>(resultUser); 
        }

        public IResult Update(UserForUpdateDto userForUpdateDto)
        {
            var resultUser = _userDal.Get(u => u.Id == userForUpdateDto.UserId);

            resultUser.FirstName = userForUpdateDto.FirtName;
            resultUser.LastName = userForUpdateDto.LastName;
            resultUser.Email = userForUpdateDto.EMail;

            _userDal.Update(resultUser);
            return new SuccessResult();
        }

        public IResult UpdatePassword(User user, string password)
        {
            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;   
            user.PasswordSalt = passwordSalt;
            
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}