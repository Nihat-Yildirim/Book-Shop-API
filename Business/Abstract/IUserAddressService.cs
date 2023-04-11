using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserAddressService
    {
        IDataResult<List<UserAddress>> GetByUserId(int userId);
        IDataResult<List<UserAddress>> GetActiveUserAddressByUserId(int userId);
        IResult Add(UserAddress userAddress);
        IResult Update(UserAddress userAddress);
    }
}