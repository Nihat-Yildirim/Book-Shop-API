using AutoMapper;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetPublisherByPattern
{
    public class GetPublisherByPatternQueryHandler : IRequestHandler<GetPublisherByPatternQueryRequest, BaseDataResponse<List<ShortPublisherDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetPublisherByPatternQueryHandler(IMapper mapper, IPublisherReadRepository publisherReadRepository)
        {
            _mapper = mapper;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortPublisherDto>>> Handle(GetPublisherByPatternQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _publisherReadRepository
                    .GetWhere(x => x.Name.Contains(request.Pattern), false)
                    .Select(x => new ShortPublisherDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                    })
                    .ToListAsync();

            return new SuccessDataResponse<List<ShortPublisherDto>>(response);
        }
    }
}