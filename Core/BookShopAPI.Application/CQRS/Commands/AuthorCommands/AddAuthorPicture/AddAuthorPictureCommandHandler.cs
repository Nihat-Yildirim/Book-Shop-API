using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthorPicture
{
    public class AddAuthorPictureCommandHandler : IRequestHandler<AddAuthorPictureCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorReadRepository _authorReadRepository;

        public AddAuthorPictureCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IAuthorReadRepository authorReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseResponse> Handle(AddAuthorPictureCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetAuthorByAuthorPictureFileAsync(x => x.Id == request.AuthorId);

            if (selectedAuthor.AuthorPictureFileId != null)
                return new FailNoDataResponse();

            if (selectedAuthor == null)
                return new FailNoDataResponse();

            var storageResult = await _storage.UploadFileAsync(request.AuthorPicture, Paths.AuthorPicturePath);

            selectedAuthor.File = new()
            {
                FileName = storageResult.FileName,
                FileExtension = storageResult.FileExtension,    
                FilePath = storageResult.FilePath,
            };

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}