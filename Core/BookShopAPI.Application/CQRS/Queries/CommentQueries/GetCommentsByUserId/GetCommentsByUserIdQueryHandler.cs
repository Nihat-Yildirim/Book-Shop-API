using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByUserId
{
    public class GetCommentsByUserIdQueryHandler : IRequestHandler<GetCommentsByUserIdQueryRequest, BaseDataResponse<List<CommentForAdminDto>>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetCommentsByUserIdQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<List<CommentForAdminDto>>> Handle(GetCommentsByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _commentReadRepository.GetCommentForAdminDtosAsync(new Pagination { Page = request.Page, Size = request.Size }, x => x.UserId == request.UserId);
            return new SuccessDataResponse<List<CommentForAdminDto>>(responseDatas);
        }
    }
}