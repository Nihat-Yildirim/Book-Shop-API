using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
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
        IResult SetDefaultCustomerAvatar(Customer customer);
        IResult UpdateCustomerAvatar(IFormFile avatar, Customer customer);
        IResult DeleteCustomerAvatar(Customer customer);
    }
}