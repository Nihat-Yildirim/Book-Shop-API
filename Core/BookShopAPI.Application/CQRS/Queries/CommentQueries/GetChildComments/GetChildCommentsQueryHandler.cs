using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetChildComments
{
    public class GetChildCommentsQueryHandler : IRequestHandler<GetChildCommentsQueryRequest, BaseDataResponse<List<CommentDto>>>
    {
        private readonly ICommentReadRepository _commendReadRepository;

        public GetChildCommentsQueryHandler(ICommentReadRepository commendReadRepository)
        {
            _commendReadRepository = commendReadRepository;
        }

        public async Task<BaseDataResponse<List<CommentDto>>> Handle(GetChildCommentsQueryRequest request, CancellationToken cancellationToken)
        {
            var resultDatas = await _commendReadRepository.GetCommentDtosAsync(x => x.ParentCommentId == request.ParentCommentId && x.DeletedDate == null);
            return new SuccessDataResponse<List<CommentDto>>(resultDatas);
        }
    }
}