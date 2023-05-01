using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Entities.DTOs.CustomerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetAllCustomerDetails(Expression<Func<CustomerDetailDto,bool>> filter = null);
        CustomerDetailDto GetCustomerDetail(Expression<Func<CustomerDetailDto,bool>> filter);
    }
}