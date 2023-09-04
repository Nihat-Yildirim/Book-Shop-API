using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthorPicture
{
    public class UpdateAuthorPictureCommandHandler : IRequestHandler<UpdateAuthorPictureCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorReadRepository _authorReadRepository;

        public UpdateAuthorPictureCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IAuthorReadRepository authorReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateAuthorPictureCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetAuthorByAuthorPictureFileAsync(x => x.Id == request.Id);

            if (selectedAuthor == null)
                return new FailNoDataResponse();

            if(selectedAuthor.File == null)
                return new FailNoDataResponse();

            var storageResult = await _storage.UpdateFileAsync(request.AuthorPicture, selectedAuthor.File.FilePath, Paths.AuthorPicturePath);

            selectedAuthor.File.FileName = storageResult.FileName;
            selectedAuthor.File.FilePath = storageResult.FilePath;
            selectedAuthor.File.FileExtension = storageResult.FileExtension;

            await  _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}