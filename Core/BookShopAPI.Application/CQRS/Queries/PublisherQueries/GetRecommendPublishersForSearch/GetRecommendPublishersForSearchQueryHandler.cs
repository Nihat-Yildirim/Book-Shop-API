using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.PublisherQueries.GetRecommendPublishersForSearch
{
    public class GetRecommendPublishersForSearchQueryHandler : IRequestHandler<GetRecommendPublishersForSearchQueryRequest, BaseDataResponse<List<ShortPublisherDto>>>
    {
        private readonly IPublisherReadRepository _publisherReadRepository;

        public GetRecommendPublishersForSearchQueryHandler(IPublisherReadRepository publisherReadRepository)
        {
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortPublisherDto>>> Handle(GetRecommendPublishersForSearchQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-14);
            var datas = await _publisherReadRepository.Table
                        .Include(x => x.PublisherSearchDatas)
                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.PublisherSearchDatas.Where(x => x.CreatedDate > minDate).Count())
                        .Take(4)
                        .AsNoTracking()
                        .ToListAsync();

            List<ShortPublisherDto> response = new();
            foreach (var data in datas)
                if (!response.Any(x => x.Id == data.Id))
                    response.Add(new()
                    {
                        Id = data.Id,
                        Name = data.Name
                    });


            return new SuccessDataResponse<List<ShortPublisherDto>>(response);
        }
    }
}