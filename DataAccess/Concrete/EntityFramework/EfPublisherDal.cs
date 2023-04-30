using Core.DataAccess.EntityFramework;
using Core.Utilities.Helpers.FileAddressHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPublisherDal : EfEntityRepositoryBase<Publisher, BookShopContext>, IPublisherDal
    {
        public List<PublisherDetailDto> GetAllPublisherDetails(Expression<Func<PublisherDetailDto, bool>> filter = null)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from p in context.Publishers
                             join f in context.Files
                             on p.FileId equals f.Id
                             select new PublisherDetailDto
                             {
                                 Id = p.Id,
                                 FileId = p.FileId,
                                 Name = p.Name,
                                 Status = p.Status,
                                 LogoAddress = FileAddressTool.CreateFileAddress(f.FilePath)
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();    
            }
        }

        public PublisherDetailDto GetPublisherDetail(Expression<Func<PublisherDetailDto, bool>> filter)
        {
            using (BookShopContext context = new BookShopContext())
            {
                var result = from p in context.Publishers
                             join f in context.Files
                             on p.FileId equals f.Id
                             select new PublisherDetailDto
                             {
                                 Id = p.Id,
                                 FileId = p.FileId,
                                 Name = p.Name,
                                 Status = p.Status,
                                 LogoAddress = FileAddressTool.CreateFileAddress(f.FilePath)
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}