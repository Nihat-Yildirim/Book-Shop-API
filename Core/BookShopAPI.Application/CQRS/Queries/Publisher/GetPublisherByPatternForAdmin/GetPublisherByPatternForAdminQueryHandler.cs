using AutoMapper;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Publisher.GetPublisherByPatternForAdmin
{
    public class GetPublisherByPatternForAdminQueryHandler : IRequestHandler<GetPublisherByPatternForAdminQueryRequest, BaseDataResponse<List<PublisherForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetPublisherByPatternForAdminQueryHandler(IMapper mapper, IPublisherReadRepository publisherReadRepository)
        {
            _mapper = mapper;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<List<PublisherForAdminDto>>> Handle(GetPublisherByPatternForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var resultPublisher = await _publisherReadRepository
                        .GetWhere(x => x.Name.Contains(request.Pattern), false)
                        .Include(x => x.File)
                        .ToListAsync();

            var responsePublisher = _mapper.Map<List<PublisherForAdminDto>>(resultPublisher);

            return new SuccessDataResponse<List<PublisherForAdminDto>>(responsePublisher);
        }
    }
}