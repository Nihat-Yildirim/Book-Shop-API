using AutoMapper;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Publisher.GetAllPublishers
{
    public class GetAllPublisherQueryHandler : IRequestHandler<GetAllPublisherQueryRequest, BaseDataResponse<List<PublisherDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetAllPublisherQueryHandler(IMapper mapper, IPublisherReadRepository publisherReadRepository)
        {
            _mapper = mapper;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<List<PublisherDto>>> Handle(GetAllPublisherQueryRequest request, CancellationToken cancellationToken)
        {
            var publishers = await _publisherReadRepository
                            .GetAll(false)
                            .Include(x => x.File)
                            .ToListAsync();

            var responsePublishers = _mapper.Map<List<PublisherDto>>(publishers);

            return new SuccessDataResponse<List<PublisherDto>>(responsePublishers);
        }
    }
}