using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByUserId
{   
    public class GetCommentsByUserIdQueryHandler : IRequestHandler<GetCommentsByUserIdQueryRequest, BaseDataResponse<ResultPaginationWithCommentDto>>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        public GetCommentsByUserIdQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<ResultPaginationWithCommentDto>> Handle(GetCommentsByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var resultComments = await _commentReadRepository.Table
                                   .Where(x => x.UserId == request.UserId && x.DeletedDate == null)
                                   .Include(x => x.CommentRatings)
                                   .Include(x => x.Book)
                                   .ThenInclude(x => x.BookPictures)
                                   .ThenInclude(x => x.File)
                                   .Skip(request.Page * request.Size)
                                   .Take(request.Size)
                                   .ToListAsync();

            if(resultComments == null)
                return new SuccessDataResponse<ResultPaginationWithCommentDto>();

            List<UserCommentWithBookDataDto> datas = new();
            foreach(var comment in resultComments)
            {
                UserCommentWithBookDataDto userCommentWithBookDataDto = new();
                userCommentWithBookDataDto.UserId = request.UserId;
                userCommentWithBookDataDto.CommentId = comment.Id;
                userCommentWithBookDataDto.Comment = comment.Comment;
                userCommentWithBookDataDto.TotalUsefulRating = comment.CommentRatings.Where(x => x.Useful == true).Count();
                userCommentWithBookDataDto.TotalNotUsefulRating = comment.CommentRatings.Where(x => x.Useful == false).Count();
                userCommentWithBookDataDto.CreatedDate = comment.CreatedDate;
                userCommentWithBookDataDto.BookId = comment.BookId;
                userCommentWithBookDataDto.BookName = comment.Book.BookName;
                userCommentWithBookDataDto.BookPictureUrl = FileUrlHelper.Generate(comment.Book.BookPictures.SingleOrDefault(x => x.ShowOrder == 1).File.FilePath);

                datas.Add(userCommentWithBookDataDto);
            }

            int commentCount = _commentReadRepository.GetWhere(x => x.UserId == request.UserId && x.DeletedDate == null).Count();
            ResultPaginationWithCommentDto response = new();
            response.CommentsCount = commentCount;
            response.Comments = datas;

            return new SuccessDataResponse<ResultPaginationWithCommentDto>(response);
        }
    }
}