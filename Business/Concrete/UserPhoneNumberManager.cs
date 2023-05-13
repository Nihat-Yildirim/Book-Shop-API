using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(UserPhoneNumberValidator))]
        [CacheRemoveAspect("IUserPhoneNumberService.Get")]
        public IResult Add(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberDal.Add(userPhoneNumber);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(UserPhoneNumberValidator))]
        [CacheRemoveAspect("IUserPhoneNumberService.Get")]
        public IResult Update(UserPhoneNumber userPhoneNumber)
        {
            _userPhoneNumberDal.Update(userPhoneNumber);

            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<UserPhoneNumber>> GetActiveUserPhoneNumbers(int userId)
        {
            var resultUserPhoneNumber = _userPhoneNumberDal.GetAll(n => n.UserId == userId && n.Status == true);

            return new SuccessDataResult<List<UserPhoneNumber>>(resultUserPhoneNumber); 
        }

        [CacheAspect]
        public IDataResult<List<UserPhoneNumber>> GetAllUserPhoneNumber(int userId)
        {
            var resultUserPhoneNumber = _userPhoneNumberDal.GetAll(n => n.UserId == userId);

            return new SuccessDataResult<List<UserPhoneNumber>>(resultUserPhoneNumber);
        }
    }
}