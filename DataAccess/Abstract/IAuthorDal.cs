using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.AuthorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAuthorDal : IEntityRepository<Author>
    {
        List<AuthorDetailDto> GetAuthorDetails(Expression<Func<AuthorDetailDto, bool>> filter = null);
        AuthorDetailDto GetAuthorDetail(Expression<Func<AuthorDetailDto, bool>> filter);
    }
}