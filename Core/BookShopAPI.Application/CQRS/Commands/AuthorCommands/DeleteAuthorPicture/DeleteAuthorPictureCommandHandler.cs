using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthorPicture
{
    public class DeleteAuthorPictureCommandHandler : IRequestHandler<DeleteAuthorPictureCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileWriteRepository _fileWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public DeleteAuthorPictureCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IAuthorReadRepository authorReadRepository, IFileWriteRepository fileWriteRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _authorReadRepository = authorReadRepository;
            _fileWriteRepository = fileWriteRepository;
        }

        public async Task<BaseResponse> Handle(DeleteAuthorPictureCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetAuthorByAuthorPictureFileAsync(x => x.Id == request.AuthorId);

            if (selectedAuthor == null)
                return new FailNoDataResponse();

            if(selectedAuthor.File == null)
                return new FailNoDataResponse();

            _storage.Delete(selectedAuthor.File.FilePath);
            _fileWriteRepository.Remove(selectedAuthor.File);
            selectedAuthor.File = null;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}