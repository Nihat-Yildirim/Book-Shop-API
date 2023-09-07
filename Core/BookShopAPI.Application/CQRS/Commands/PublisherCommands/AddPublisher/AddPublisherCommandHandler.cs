using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherCommands.AddPublisher
{
    public class AddPublisherCommandHandler : IRequestHandler<AddPublisherCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherReadRepository _publisherReadRepository;
        private readonly IPublisherWriteRepository _publisherWriteRepository;

        public AddPublisherCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IPublisherReadRepository publisherReadRepository, IPublisherWriteRepository publisherWriteRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _publisherReadRepository = publisherReadRepository;
            _publisherWriteRepository = publisherWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddPublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedPublisher = await _publisherReadRepository.GetSingleAsync(x => x.Name == request.Name);

            if (selectedPublisher != null)
                return new FailNoDataResponse();

            var storageResult = await _storage.UploadFileAsync(request.Logo, Paths.PublisherLogoPath);
            
            Publisher publisher = new()
            {
                Name = request.Name,
                File = new()
                {
                    FileName = storageResult.FileName,
                    FileExtension = storageResult.FileExtension,
                    FilePath = storageResult.FilePath,
                }
            };

            await _publisherWriteRepository.AddAsync(publisher);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}