using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BookShopContext>, ICustomerDal
    {
        public CustomerDetailDto GetByEmail(string email)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from u in context.Users
                             where u.Email == email
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 PasswordHash = u.PasswordHash,
                                 PasswordSalt = u.PasswordSalt,
                                 CreatedDate = u.CreatedDate,
                                 Status = u.Status
                             };

                return (CustomerDetailDto)result;
            }
        }
    }
}
