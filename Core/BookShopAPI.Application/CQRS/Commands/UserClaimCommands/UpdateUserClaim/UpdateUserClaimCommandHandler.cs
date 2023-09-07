using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.UserClaimCommands.UpdateUserClaim
{
    public class UpdateUserClaimCommandHandler : IRequestHandler<UpdateUserClaimCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public UpdateUserClaimCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateUserClaimCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                    .Include(x => x.UserClaim)
                                    .SingleOrDefaultAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if(selectedUser.UserClaim == null)
                return new FailNoDataResponse();

            selectedUser.UserClaim.ClaimId = (int)request.Claim;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}