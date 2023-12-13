using BookShopAPI.Application.DTOs.ViewDTOs;
using BookShopAPI.Application.Repositories.ViewRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.ViewQueries.GetSelectedBookViewDatasForDays
{
    public class GetSelectedBookViewDatasForDaysQueryHandler : IRequestHandler<GetSelectedBookViewDatasForDaysQueryRequest, BaseDataResponse<List<ViewCountForDaysDto>>>
    {
        private readonly IViewReadRepository _viewReadRepository;

        public GetSelectedBookViewDatasForDaysQueryHandler(IViewReadRepository viewReadRepository)
        {
            _viewReadRepository = viewReadRepository;
        }

        public async Task<BaseDataResponse<List<ViewCountForDaysDto>>> Handle(GetSelectedBookViewDatasForDaysQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-6);
            var datas = await _viewReadRepository.GetWhere(x => x.BookId == request.BookId && x.CreatedDate > minDate , false).OrderBy(x => x.CreatedDate).ToListAsync();
            List<ViewCountForDaysDto> response = new();

            for(int i = 0; i <= 6; i++)
            {
                response.Add(new ViewCountForDaysDto
                {
                    Date = minDate.AddDays(i).ToString("dd"),
                    ViewCount = datas.Where(x => x.CreatedDate.Day == minDate.AddDays(i).Day).Count()
                });
            }

            return new SuccessDataResponse<List<ViewCountForDaysDto>>(response);
        }
    }
}