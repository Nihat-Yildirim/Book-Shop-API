using Business.Abstract;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
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
    public class UserClaimManager : IUserClaimService
    {
        IUserClaimDal _userClaimDal;
        public UserClaimManager(IUserClaimDal userClaimDal)
        {
            _userClaimDal = userClaimDal;
        }

        [TransactionScopeAspect]
        [PerformanceAspect(15)]
        public IResult Add(int userId, int claimId)
        {
            UserClaim userClaim = new();
            userClaim.UserId = userId;
            userClaim.ClaimId = claimId;

            _userClaimDal.Add(userClaim);

            return new SuccessResult();
        }
    }
}