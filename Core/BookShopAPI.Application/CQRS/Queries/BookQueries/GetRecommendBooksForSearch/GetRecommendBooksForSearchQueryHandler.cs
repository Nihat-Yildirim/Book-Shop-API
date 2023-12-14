using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetRecommendBooksForSearch
{
    public class GetRecommendBooksForSearchQueryHandler : IRequestHandler<GetRecommendBooksForSearchQueryRequest, BaseDataResponse<List<ShortBookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetRecommendBooksForSearchQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortBookDto>>> Handle(GetRecommendBooksForSearchQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-14);
            var datas = await _bookReadRepository.Table
                        .Include(x => x.BookSearchDatas)
                        .Where(x => x.DeletedDate == null)
                        .OrderByDescending(x => x.BookSearchDatas.Where(x => x.CreatedDate > minDate).Count())
                        .Take(8)
                        .AsNoTracking()
                        .ToListAsync();

            List<ShortBookDto> response = new();
            foreach (var data in datas)
                if (!response.Any(x => x.Id == data.Id))
                    response.Add(new()
                    {
                        Id = data.Id,
                        Name = data.BookName
                    });


            return new SuccessDataResponse<List<ShortBookDto>>(response);
        }
    }
}