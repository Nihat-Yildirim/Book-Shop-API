using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.StoreDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStoreDal : IEntityRepository<Store>
    {
        List<StoreDetailDto> GetAllStoreDetail(Expression<Func<StoreDetailDto, bool>> filter = null);
        StoreDetailDto GetStoreDetail(Expression<Func<StoreDetailDto, bool>> filter);
    }
}