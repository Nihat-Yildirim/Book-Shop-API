using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.UserCommands.DeleteUserAvatar
{
    public class DeleteUserAvatarCommandHandler : IRequestHandler<DeleteUserAvatarCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IFileWriteRepository _fileWriteRepository;

        public DeleteUserAvatarCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IFileWriteRepository fileWriteRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _fileWriteRepository = fileWriteRepository;
        }

        public async Task<BaseResponse> Handle(DeleteUserAvatarCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithUserAvatarFileAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            _storage.Delete(selectedUser.File.FilePath);
            _fileWriteRepository.Remove(selectedUser.File);

            selectedUser.File = null;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}