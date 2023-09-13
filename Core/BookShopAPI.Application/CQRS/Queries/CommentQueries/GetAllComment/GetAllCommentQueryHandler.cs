using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetAllComment
{
    public class GetAllCommentQueryHandler : IRequestHandler<GetAllCommentQueryRequest, BaseDataResponse<List<CommentForAdminDto>>>
    {
        private readonly ICommentReadRepository _commendReadRepository;

        public GetAllCommentQueryHandler(ICommentReadRepository commendReadRepository)
        {
            _commendReadRepository = commendReadRepository;
        }

        public async Task<BaseDataResponse<List<CommentForAdminDto>>> Handle(GetAllCommentQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _commendReadRepository.GetCommentForAdminDtosAsync(new Pagination { Page = request.Page, Size = request.Size });
            return new SuccessDataResponse<List<CommentForAdminDto>>(responseDatas);
        }
    }
}