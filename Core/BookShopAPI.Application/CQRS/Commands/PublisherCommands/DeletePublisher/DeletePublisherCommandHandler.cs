using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PublisherCommands.DeletePublisher
{
    public class DeletePublisherCommandHandler : IRequestHandler<DeletePublisherCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public DeletePublisherCommandHandler(IUnitOfWork unitOfWork, IPublisherReadRepository publisherReadRepository)
        {
            _unitOfWork = unitOfWork;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseResponse> Handle(DeletePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedPublisher = await _publisherReadRepository.GetByIdAsync(request.PublisherId);

            if (selectedPublisher == null)
                return new FailNoDataResponse();

            selectedPublisher.DeletedDate = DateTime.Now;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}