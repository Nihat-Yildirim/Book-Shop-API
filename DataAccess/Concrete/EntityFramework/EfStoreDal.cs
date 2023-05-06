using Core.DataAccess.EntityFramework;
using Core.Utilities.Helpers.FileAddressHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.StoreDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStoreDal : EfEntityRepositoryBase<Store, BookShopContext>, IStoreDal
    {
        public List<StoreDetailDto> GetAllStoreDetail(Expression<Func<StoreDetailDto, bool>> filter = null)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from store in context.Stores
                             join dealer in context.Dealers
                             on store.Id equals dealer.StoreId
                             join user in context.Users
                             on dealer.UserId equals user.Id
                             join file in context.Files
                             on store.FileId equals file.Id
                             select new StoreDetailDto
                             {
                                 DealerId = dealer.Id,
                                 StoreId = store.Id,
                                 DealerFirstName = user.FirstName,
                                 DealerLastName = user.LastName,
                                 StoreDescription = store.Description,
                                 StoreName = store.Name,
                                 LogoAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

        public StoreDetailDto GetStoreDetail(Expression<Func<StoreDetailDto, bool>> filter)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from store in context.Stores
                             join dealer in context.Dealers
                             on store.Id equals dealer.StoreId
                             join user in context.Users
                             on dealer.UserId equals user.Id
                             join file in context.Files
                             on store.FileId equals file.Id
                             select new StoreDetailDto
                             {
                                 DealerId = dealer.Id,
                                 StoreId = store.Id,
                                 DealerFirstName = user.FirstName,
                                 DealerLastName = user.LastName,
                                 StoreDescription = store.Description,
                                 StoreName = store.Name,
                                 LogoAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}