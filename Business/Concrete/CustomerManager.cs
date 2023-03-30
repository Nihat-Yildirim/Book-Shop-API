using Business.Abstract;
using Business.FileHelpers.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        ICustomerAvatarFileService _customerAvatarFileService;
        public CustomerManager(ICustomerDal customerDal,ICustomerAvatarFileService customerAvatarFileService)
        {
            _customerDal = customerDal;
            _customerAvatarFileService= customerAvatarFileService;
        }

        public IResult Add(Customer customer)
        {
            var result = BusinessRules.Run(CheckCustomerAvatarImage(customer.ProfilePicture));
            if(!result.Success)
            {
                customer.ProfilePicture = _customerAvatarFileService.SetDefaultCustomerAvatar();
                _customerDal.Add(customer);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            _customerAvatarFileService.DeleteCustomerAvatar(customer.ProfilePicture);
            return new SuccessResult();
        }

        public IDataResult<Customer> GetByMail(string email)
        {
            var result = _customerDal.Get(c => c.Email == email);
            if(result == null)
            {
                return new ErrorDataResult<Customer>();
            }
            return new SuccessDataResult<Customer>(result);
        }

        public IResult Update(int id,IFormFile file)
        {
            var customer = _customerDal.Get(c => c.Id == id);
            var result = _customerAvatarFileService.UpdateCustomerAvatar(file,customer.ProfilePicture);
            var updatedCustomer = customer;
            updatedCustomer.ProfilePicture = result;
            _customerDal.Update(updatedCustomer);

            return new SuccessResult();
        }

        private IResult CheckCustomerAvatarImage(string customerAvatar)
        {
            if(customerAvatar == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}