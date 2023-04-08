using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerAvatarService
    {
        IDataResult<CustomerAvatar> GetByCustomerId(int customerId);
        IResult UpdateCustomerAvatar(IFormFile avatar, int customerId);
        IResult AddCustomerAvatar(IFormFile avatar, int customerId);
        IResult DeleteCustomerAvatar(int customerId);
    }
}