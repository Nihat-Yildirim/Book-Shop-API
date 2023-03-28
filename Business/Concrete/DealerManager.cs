using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
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

        public IResult Delete(Dealer dealer)
        {
            _dealerDal.Delete(dealer);
            return new SuccessResult();
        }

        public IDataResult<Dealer> GetByMail(string email)
        {
            var result = _dealerDal.Get(d => d.Email == email);
            if (result == null)
            {
                return new ErrorDataResult<Dealer>();
            }
            return new SuccessDataResult<Dealer>(result);

        }

        public IResult Update(Dealer dealer)
        {
            _dealerDal.Update(dealer);
            return new SuccessResult();
        }
    }
}