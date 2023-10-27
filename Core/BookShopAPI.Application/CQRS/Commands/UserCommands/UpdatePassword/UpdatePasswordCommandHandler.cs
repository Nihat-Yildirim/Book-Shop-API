using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.UserCommands.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public UpdatePasswordCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetByIdAsync(request.UserId);
            if (selectedUser == null)
                return new FailNoDataResponse();

            bool isVerify = HashingHelper.VerifyPasswordHash(request.OldPassword, selectedUser.PasswordHash, selectedUser.PasswordSalt);
            if(!isVerify)
                return new FailNoDataResponse();

            byte[] newPassswordHash, newPassswordSalt;
            HashingHelper.CreatePasswordHash(request.NewPassword,out newPassswordHash,out newPassswordSalt);

            selectedUser.PasswordHash = newPassswordHash;
            selectedUser.PasswordSalt = newPassswordSalt;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}