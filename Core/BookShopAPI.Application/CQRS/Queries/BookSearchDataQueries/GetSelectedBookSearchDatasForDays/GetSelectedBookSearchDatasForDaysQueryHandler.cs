using BookShopAPI.Application.DTOs.BookSearchDataDTOs;
using BookShopAPI.Application.Repositories.BookSearchDataRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookSearchDataQueries.GetSelectedBookSearchDatasForDays
{
    public class GetSelectedBookSearchDatasForDaysQueryHandler : IRequestHandler<GetSelectedBookSearchDatasForDaysQueryRequest, BaseDataResponse<List<BookSearchCountForDaysDto>>>
    {
        private readonly IBookSearchDataReadRepository _bookSearchDataReadRepository;

        public GetSelectedBookSearchDatasForDaysQueryHandler(IBookSearchDataReadRepository bookSearchDataReadRepository)
        {
            _bookSearchDataReadRepository = bookSearchDataReadRepository;
        }

        public async Task<BaseDataResponse<List<BookSearchCountForDaysDto>>> Handle(GetSelectedBookSearchDatasForDaysQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-6);
            var datas = await _bookSearchDataReadRepository.GetWhere(x => x.BookId == request.BookId && x.CreatedDate > minDate, false).ToListAsync();
            List<BookSearchCountForDaysDto> response = new();

            for (int i = 0; i <= 6; i++)
            {
                response.Add(new BookSearchCountForDaysDto
                {
                    Date = minDate.AddDays(i).ToString("dd"),
                    SearchCount = datas.Where(x => x.CreatedDate.Day == minDate.AddDays(i).Day).Count()
                });
            }

            return new SuccessDataResponse<List<BookSearchCountForDaysDto>>(response);
        }
    }
}