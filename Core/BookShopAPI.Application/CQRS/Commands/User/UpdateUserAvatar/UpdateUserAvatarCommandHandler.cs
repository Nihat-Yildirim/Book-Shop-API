using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.User.UpdateUserAvatar
{
    public class UpdateUserAvatarCommandHandler : IRequestHandler<UpdateUserAvatarCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public UpdateUserAvatarCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateUserAvatarCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithUserAvatarFile(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var storageResult = await _storage.UpdateFileAsync(request.UserAvatar, selectedUser.File.FilePath, Paths.UserAvatarPath);

            selectedUser.File.FileName = storageResult.FileName;
            selectedUser.File.FilePath = storageResult.FilePath;
            selectedUser.File.FileExtension = storageResult.FileExtension;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}