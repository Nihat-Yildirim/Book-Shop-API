using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserPhoneNumberService
    {
        IDataResult<List<UserPhoneNumber>> GetActiveUserPhoneNumbers(int userId);
        IDataResult<List<UserPhoneNumber>> GetAllUserPhoneNumber(int userId);
        IResult Add(UserPhoneNumber userPhoneNumber);
        IResult Update(UserPhoneNumber userPhoneNumber);
    }
}
