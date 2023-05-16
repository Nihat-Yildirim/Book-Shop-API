using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
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
    public class UserAddressManager : IUserAddressService
    {
        IUserAddressDal _userAddressDal;
        public UserAddressManager(IUserAddressDal userAddressDal)
        {
            _userAddressDal = userAddressDal;
        }

        [ValidationAspect(typeof(UserAddressValidator))]
        [CacheRemoveAspect("IUserAddressService.Get")]
        [PerformanceAspect(15)]
        public IResult Add(UserAddress userAddress)
        {
            _userAddressDal.Add(userAddress);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(UserAddressValidator))]
        [CacheRemoveAspect("IUserAddressService.Get")]
        [PerformanceAspect(15)]
        public IResult Update(UserAddress userAddress)
        {
            _userAddressDal.Update(userAddress);

            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<UserAddress>> GetActiveUserAddressByUserId(int userId)
        {
            var resultUserAddresses = _userAddressDal.GetAll(u => u.UserId == userId && u.Status == true);

            return new SuccessDataResult<List<UserAddress>>(resultUserAddresses);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<UserAddress>> GetByUserId(int userId)
        {
            var resultUserAddress = _userAddressDal.GetAll(u => u.UserId == userId);

            return new SuccessDataResult<List<UserAddress>>(resultUserAddress);
        }

    }
}