using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDealerService
    {
        IDataResult<Dealer> GetByUserId(int userId);
        IResult Add(Dealer dealer);
        IResult Update(Dealer dealer);
    }
}