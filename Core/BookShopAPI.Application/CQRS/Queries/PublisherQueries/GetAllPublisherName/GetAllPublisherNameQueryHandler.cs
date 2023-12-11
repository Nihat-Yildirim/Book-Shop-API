using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetAllPublisherName
{
    public class GetAllPublisherNameQueryHandler : IRequestHandler<GetAllPublisherNameQueryRequest, BaseDataResponse<List<ShortPublisherDto>>>
    {
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetAllPublisherNameQueryHandler(IPublisherReadRepository publisherReadRepository)
        {
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortPublisherDto>>> Handle(GetAllPublisherNameQueryRequest request, CancellationToken cancellationToken)
        {
            var datas = await _publisherReadRepository.GetAll(false).ToListAsync();
            List<ShortPublisherDto> response = new();

            foreach (var data in datas)
                response.Add(new ShortPublisherDto
                {
                    Id = data.Id,
                    Name = data.Name,
                });

            return new SuccessDataResponse<List<ShortPublisherDto>>(response);
        }
    }
}