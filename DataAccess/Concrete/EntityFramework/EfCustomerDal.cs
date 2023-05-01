using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Helpers.FileAddressHelper;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs.CustomerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BookShopContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetAllCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.FileId equals user.Id
                             join file in context.Files
                             on customer.FileId equals file.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = customer.Id,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CreatedDate = user.CreatedDate,
                                 Status = user.Status,
                                 AvatarFileAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

        public CustomerDetailDto GetCustomerDetail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (BookShopContext context = new BookShopContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.FileId equals user.Id
                             join file in context.Files
                             on customer.FileId equals file.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = customer.Id,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CreatedDate = user.CreatedDate,
                                 Status = user.Status,
                                 AvatarFileAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}
