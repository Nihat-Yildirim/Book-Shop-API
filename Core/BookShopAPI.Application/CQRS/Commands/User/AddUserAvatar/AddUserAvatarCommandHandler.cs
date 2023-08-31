using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar
{
    public class AddUserAvatarCommandHandler : IRequestHandler<AddUserAvatarCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public AddUserAvatarCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(AddUserAvatarCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithUserAvatarFile(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var resultFile = await _storage.UploadFileAsync(request.UserAvatar,Paths.UserAvatarPath);

            selectedUser.File = new()
            {
                FileName = resultFile.FileName,
                FilePath = resultFile.FilePath, 
                FileExtension = resultFile.FileExtension,   
            };

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}