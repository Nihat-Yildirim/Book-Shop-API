using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedBookCommentDatasForDays
{
    public class GetSelectedBookCommentDatasForDaysQueryRequest : IRequest<BaseDataResponse<List<CommentCountForDaysDto>>>
    {
        public int BookId { get; set; }
    }
}