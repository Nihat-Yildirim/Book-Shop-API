using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedBookCommentDatasForDays
{
    public class GetSelectedBookCommentDatasForDaysQueryHandler : IRequestHandler<GetSelectedBookCommentDatasForDaysQueryRequest, BaseDataResponse<List<CommentCountForDaysDto>>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetSelectedBookCommentDatasForDaysQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<List<CommentCountForDaysDto>>> Handle(GetSelectedBookCommentDatasForDaysQueryRequest request, CancellationToken cancellationToken)
        {
            var minDate = DateTime.Now.AddDays(-6);
            var datas = await _commentReadRepository.GetWhere(x => x.BookId == request.BookId && x.CreatedDate > minDate && x.DeletedDate == null, false).ToListAsync();

            List<CommentCountForDaysDto> response = new();
            for (int i = 0; i <= 6; i++)
            {
                response.Add(new CommentCountForDaysDto
                {
                    Date = minDate.AddDays(i).ToString("dd"),
                    CommentCount = datas.Where(x => x.CreatedDate.Day == minDate.AddDays(i).Day).Count()
                });
            }

            return new SuccessDataResponse<List<CommentCountForDaysDto>>(response);
        }
    }
}