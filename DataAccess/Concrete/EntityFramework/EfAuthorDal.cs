using Core.DataAccess.EntityFramework;
using Core.Utilities.Helpers.FileAddressHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.AuthorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, BookShopContext>, IAuthorDal
    {
        public AuthorDetailDto GetAuthorDetail(Expression<Func<AuthorDetailDto, bool>> filter)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from author in context.Authors
                             join file in context.Files
                             on author.FileId equals file.Id
                             select new AuthorDetailDto
                             {
                                 Id = author.Id,
                                 FirstName = author.FirstName,
                                 LastName = author.LastName,    
                                 Autobiography = author.Autobiography,
                                 Status = author.Status,
                                 AuthorPictureAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return result.SingleOrDefault(filter);
            }
        }

        public List<AuthorDetailDto> GetAuthorDetails(Expression<Func<AuthorDetailDto, bool>> filter = null)
        {
            using(BookShopContext context = new BookShopContext())
            {
                var result = from author in context.Authors
                             join file in context.Files
                             on author.FileId equals file.Id
                             select new AuthorDetailDto
                             {
                                 Id = author.Id,
                                 FirstName = author.FirstName,
                                 LastName = author.LastName,
                                 Autobiography = author.Autobiography,
                                 Status = author.Status,
                                 AuthorPictureAddress = FileAddressTool.CreateFileAddress(file.FilePath)
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}