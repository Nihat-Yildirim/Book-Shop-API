using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandHandler : IRequestHandler<UpdatePublisherCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public UpdatePublisherCommandHandler(IUnitOfWork unitOfWork, IPublisherReadRepository publisherReadRepository)
        {
            _unitOfWork = unitOfWork;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdatePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedPublisher = await _publisherReadRepository.GetByIdAsync(request.PublisherId);

            if (selectedPublisher == null)
                return new FailNoDataResponse();

            if (selectedPublisher.DeletedDate != null)
                return new FailNoDataResponse();

            selectedPublisher.Name = request.Name;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}