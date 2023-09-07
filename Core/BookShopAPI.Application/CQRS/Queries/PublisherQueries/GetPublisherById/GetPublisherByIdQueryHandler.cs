using AutoMapper;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherById
{
    public class GetPublisherByIdQueryHandler : IRequestHandler<GetPublisherByIdQueryRequest, BaseDataResponse<PublisherDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetPublisherByIdQueryHandler(IMapper mapper, IPublisherReadRepository publisherReadRepository)
        {
            _mapper = mapper;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<PublisherDto>> Handle(GetPublisherByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedPublishler = await _publisherReadRepository.GetPublisherByPublisherLogoFileAsync(x => x.Id == request.PublisherId, false);
            var responsePublisher = _mapper.Map<PublisherDto>(selectedPublishler);  

            return new SuccessDataResponse<PublisherDto>(responsePublisher);
        }
    }
}