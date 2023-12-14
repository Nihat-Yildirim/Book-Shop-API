using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetRecommendAuthorsForSearch
{
    public class GetRecommendAuthorsForSearchQueryHandler : IRequestHandler<GetRecommendAuthorsForSearchQueryRequest, BaseDataResponse<List<ShortAuthorDto>>>
    {
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetRecommendAuthorsForSearchQueryHandler(IAuthorReadRepository authorReadRepository)
        {
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortAuthorDto>>> Handle(GetRecommendAuthorsForSearchQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-14);
            var datas = await _authorReadRepository.Table
                        .Include(x => x.AuthorSearchDatas)
                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.AuthorSearchDatas.Where(x => x.CreatedDate > minDate).Count())
                        .Take(5)
                        .AsNoTracking()
                        .ToListAsync();

            List<ShortAuthorDto> response = new();
            foreach (var data in datas)
                if (!response.Any(x => x.Id == data.Id))
                    response.Add(new()
                    {
                        Id = data.Id,
                        Name = data.Name
                    });

            return new SuccessDataResponse<List<ShortAuthorDto>>(response);
        }
    }
}