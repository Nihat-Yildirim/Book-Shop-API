using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, BookShopContext>, IUserDal
    {
        public List<Claim> GetUserClaims(User user)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from userClaim in context.UserClaims
                             where userClaim.UserId == user.Id
                             join claim in context.Claims
                             on userClaim.ClaimId equals claim.Id
                             select new Claim
                             {
                                 Id = claim.Id,
                                 Name = claim.Name,
                             };

                return result.ToList();
            }
        }
    }
}