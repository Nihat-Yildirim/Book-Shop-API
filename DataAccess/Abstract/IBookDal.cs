using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<BookDetailDto> GetAllBookDetail(Expression<Func<BookDetailDto,bool>> filter = null);
        BookDetailDto GetBookDetail(Expression<Func<BookDetailDto, bool>> filter);
    }
}