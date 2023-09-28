using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId
{
    public class GetCommentsByBookIdQueryHandler : IRequestHandler<GetCommentsByBookIdQueryRequest, BaseDataResponse<ResultCommentDto>>
    {
        private readonly ICommentReadRepository _commendReadRepository;

        public GetCommentsByBookIdQueryHandler(ICommentReadRepository commendReadRepository)
        {
            _commendReadRepository = commendReadRepository;
        }

        public async Task<BaseDataResponse<ResultCommentDto>> Handle(GetCommentsByBookIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _commendReadRepository.GetCommentDtosAsync(new Pagination { Page = request.Page , Size = request.Size},request.UserId,x => x.BookId == request.BookId && x.DeletedDate == null);
            int commentsCount = _commendReadRepository.GetWhere(x => x.BookId == request.BookId && x.DeletedDate == null).Count();
            ResultCommentDto resultCommentDto = new()
            {
                Comments = responseDatas,
                CommentsCount = commentsCount
            };
            return new SuccessDataResponse<ResultCommentDto>(resultCommentDto);
        }
    }
}