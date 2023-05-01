using Core.DataAccess.EntityFramework;
using Core.Utilities.Helpers.FileAddressHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.PublisherDTOs;
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
                var result = from publisher in context.Publishers
                             join file in context.Files
                             on publisher.FileId equals file.Id
                             select new PublisherDetailDto
                             {
                                 Id = publisher.Id,
                                 FileId = publisher.FileId,
                                 Name = publisher.Name,
                                 Status = publisher.Status,
                                 LogoAddress = FileAddressTool.CreateFileAddress(file.FilePath)
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
                var result = from publisher in context.Publishers
                             join file in context.Files
                             on publisher.FileId equals file.Id
                             select new PublisherDetailDto
                             {
                                 Id = publisher.Id,
                                 FileId = publisher.FileId,
                                 Name = publisher.Name,
                                 Status = publisher.Status,
                                 LogoAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}