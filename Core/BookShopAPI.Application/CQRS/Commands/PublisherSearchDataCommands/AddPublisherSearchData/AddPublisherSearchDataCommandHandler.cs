using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.Repositories.PublisherSearchDataRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherSearchDataCommands.AddPublisherSearchData
{
    public class AddPublisherSearchDataCommandHandler : IRequestHandler<AddPublisherSearchDataCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherReadRepository _publisherReadRepository;
        private readonly IPublisherSearchDataWriteRepository _publisherSearchDataWriteRepository;

        public AddPublisherSearchDataCommandHandler(IUnitOfWork unitOfWork, IPublisherReadRepository publisherReadRepository, IPublisherSearchDataWriteRepository publisherSearchDataWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _publisherReadRepository = publisherReadRepository;
            _publisherSearchDataWriteRepository = publisherSearchDataWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddPublisherSearchDataCommandRequest request, CancellationToken cancellationToken)
        {
            bool isPublisherExists = await _publisherReadRepository.AnyAsync(x => x.Id == request.PublisherId);
            if (!isPublisherExists)
                return new FailNoDataResponse();

            PublisherSearchData publisherSearchData = new();
            publisherSearchData.PublisherId = request.PublisherId;

            await _publisherSearchDataWriteRepository.AddAsync(publisherSearchData);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}