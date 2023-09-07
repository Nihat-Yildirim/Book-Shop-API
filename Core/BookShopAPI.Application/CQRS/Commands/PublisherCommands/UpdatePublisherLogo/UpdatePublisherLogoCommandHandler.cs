using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherCommands.UpdatePublisherLogo
{
    public class UpdatePublisherLogoCommandHandler : IRequestHandler<UpdatePublisherLogoCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public UpdatePublisherLogoCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IPublisherReadRepository publisherReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdatePublisherLogoCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedPublisher = await _publisherReadRepository.GetPublisherByPublisherLogoFileAsync(x => x.Id == request.PublisherId);

            if (selectedPublisher == null)
                return new FailNoDataResponse();

            if (selectedPublisher.DeletedDate != null)
                return new FailNoDataResponse();

            if(selectedPublisher.File == null)
                return new FailNoDataResponse();

            var storageResult = await _storage.UpdateFileAsync(request.Logo, selectedPublisher.File.FilePath, Paths.AuthorPicturePath);

            selectedPublisher.File.FilePath = storageResult.FilePath;
            selectedPublisher.File.FileExtension = storageResult.FileExtension; 
            selectedPublisher.File.FileName = selectedPublisher.File.FileName;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}