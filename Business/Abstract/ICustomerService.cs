using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<CustomerDetailDto> GetCustomerDetails(string email);
        IDataResult<Customer> GetByUserId(int userId);
        IResult Add(Customer customer);
    }
}