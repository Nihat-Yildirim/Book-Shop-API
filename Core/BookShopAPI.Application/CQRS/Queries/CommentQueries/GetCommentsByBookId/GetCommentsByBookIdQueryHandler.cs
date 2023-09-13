using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId
{
    public class GetCommentsByBookIdQueryHandler : IRequestHandler<GetCommentsByBookIdQueryRequest, BaseDataResponse<List<CommentDto>>>
    {
        private readonly ICommentReadRepository _commendReadRepository;

        public GetCommentsByBookIdQueryHandler(ICommentReadRepository commendReadRepository)
        {
            _commendReadRepository = commendReadRepository;
        }

        public async Task<BaseDataResponse<List<CommentDto>>> Handle(GetCommentsByBookIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _commendReadRepository.GetCommentDtosAsync(x => x.BookId == request.BookId && x.DeletedDate == null);
            return new SuccessDataResponse<List<CommentDto>>(responseDatas);
        }
    }
}