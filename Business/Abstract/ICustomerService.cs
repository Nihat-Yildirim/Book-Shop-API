using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs.CustomerDTOs;
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
        IDataResult<CustomerDetailDto> GetCustomerDetailsByEmail(string email);
        IDataResult<CustomerDetailDto> GetCustomerDetailById(int customerId);
        IDataResult<Customer> GetCustomerById(int customerId);
        IDataResult<Customer> GetByUserId(int userId);
        IResult Add(Customer customer);
        IResult AddCustomerAvatar(int customerId, IFormFile avatar);
        IResult DeleteCustomerAvatar(int customerId);
        IResult UpdateCustomerAvatar(int customerId, IFormFile avatar);
    }
}