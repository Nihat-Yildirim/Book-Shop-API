using Business.Abstract;
using Business.Constants.PathConstants;
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
        ICustomerAvatarService _customerAvatarService;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);

            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<Customer> GetById(int id)
        {
            var result = _customerDal.Get(c => c.Id == id);
            if(result != null)
            {
                return new SuccessDataResult<Customer>(result);
            }
            return new ErrorDataResult<Customer>();
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

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}