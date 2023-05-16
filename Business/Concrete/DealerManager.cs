using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(DealerValidator))]
        [PerformanceAspect(15)]
        public IResult Add(Dealer dealer)
        {
            _dealerDal.Add(dealer);
            return new SuccessResult();
        }

        [PerformanceAspect(15)]
        public IDataResult<Dealer> GetByDealerId(int dealerId)
        {
            var resultDealer = _dealerDal.Get(d => d.Id == dealerId);
            return new SuccessDataResult<Dealer>(resultDealer);
        }

        [PerformanceAspect(15)]
        public IDataResult<Dealer> GetByUserId(int userId)
        {
            var resultDealer = _dealerDal.Get(d => d.UserId == userId);
            return new SuccessDataResult<Dealer>(resultDealer);
        }
    }
}