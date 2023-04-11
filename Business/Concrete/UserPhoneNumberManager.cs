using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserPhoneNumberManager : IUserPhoneNumberService
    {
        IUserPhoneNumberDal _userPhoneNumberDal;
        public UserPhoneNumberManager(IUserPhoneNumberDal userPhoneNumberDal)
        {
            _userPhoneNumberDal = userPhoneNumberDal;
        }

        public IResult Add(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberDal.Add(userPhoneNumber);

            return new SuccessResult();
        }

        public IDataResult<List<UserPhoneNumber>> GetActiveUserPhoneNumbers(int userId)
        {
            var resultUserPhoneNumber = _userPhoneNumberDal.GetAll(n => n.UserId == userId && n.Status == true);

            return new SuccessDataResult<List<UserPhoneNumber>>(resultUserPhoneNumber); 
        }

        public IDataResult<List<UserPhoneNumber>> GetAllUserPhoneNumber(int userId)
        {
            var resultUserPhoneNumber = _userPhoneNumberDal.GetAll(n => n.UserId == userId);

            return new SuccessDataResult<List<UserPhoneNumber>>(resultUserPhoneNumber);
        }

        public IResult Update(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberDal.Update(userPhoneNumber);

            return new SuccessResult();
        }
    }
}