using BookShopAPI.Application.DTOs.BookSearchDataDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookSearchDataQueries.GetSelectedBookSearchDatasForDays
{
    public class GetSelectedBookSearchDatasForDaysQueryRequest : IRequest<BaseDataResponse<List<BookSearchCountForDaysDto>>>
    {
        public int BookId { get; set; }
    }
}