using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPublisherDal : IEntityRepository<Publisher>
    {
        List<PublisherDetailDto> GetAllPublisherDetails(Expression<Func<PublisherDetailDto, bool>> filter = null);
        PublisherDetailDto GetPublisherDetail(Expression<Func<PublisherDetailDto, bool>> filter);
    }
}