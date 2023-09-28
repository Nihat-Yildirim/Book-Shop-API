using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedBookUserComment
{
    public class GetSelectedBookUserCommentQueryHandler : IRequestHandler<GetSelectedBookUserCommentQueryRequest, BaseDataResponse<ShortCommentDto>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetSelectedBookUserCommentQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<ShortCommentDto>> Handle(GetSelectedBookUserCommentQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedComment = await _commentReadRepository.Table.Include(x => x.CommentRatings)
                .SingleOrDefaultAsync(x => x.UserId == request.UserId && x.BookId == request.BookId && x.DeletedDate == null);

            if (selectedComment == null) 
                return new SuccessDataResponse<ShortCommentDto>();

            ShortCommentDto shortCommentDto = new()
            {
                CommentId = selectedComment.Id,
                Comment = selectedComment.Comment,
                TotalUsefulRating = selectedComment.CommentRatings.Where(x => x.Useful == true).Count(),
                TotalNotUsefulRating = selectedComment.CommentRatings.Where(x => x.Useful == false).Count(),
            };

            return new SuccessDataResponse<ShortCommentDto>(shortCommentDto);
        }
    }
}
