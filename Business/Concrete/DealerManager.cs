using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DealerManager : IDealerService
    {
        IDealerDal _dealerDal;
        public DealerManager(IDealerDal dealerDal)
        {
            _dealerDal = dealerDal;
        }

        public IResult Add(Dealer dealer)
        {
            _dealerDal.Add(dealer);
            return new SuccessResult();
        }

        public IDataResult<Dealer> GetByUserId(int userId)
        {
            var resultDealer = _dealerDal.Get(d => d.UserId == userId);
            return new SuccessDataResult<Dealer>(resultDealer);
        }

        public IResult Update(Dealer dealer)
        {
            _dealerDal.Update(dealer);
            return new SuccessResult();
        }
    }
}