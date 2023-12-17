using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookIdForAdmin
{
    public class GetCommentsByBookIdForAdminQueryHandler : IRequestHandler<GetCommentsByBookIdForAdminQueryRequest, BaseDataResponse<ResultCommentForAdminDto>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetCommentsByBookIdForAdminQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<ResultCommentForAdminDto>> Handle(GetCommentsByBookIdForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var datas = await _commentReadRepository.Table
                        .Include(x => x.CommentRatings)
                        .Include(x => x.User)
                        .ThenInclude(x => x.File)
                        .Where(x => x.BookId == request.BookId && x.DeletedDate == null)
                        .Skip(request.Page * request.Size)
                        .Take(request.Size)
                        .AsNoTracking()
                        .ToListAsync();


            List<CommentForAdminDto> commentDatas = new();

            foreach (var data in datas)
            {
                CommentForAdminDto commentForAdminDto = new()
                {
                    BookId = data.BookId,
                    UserFirstName = data.User.FirstName,
                    UserLastName = data.User.LastName,
                    PictureUrl = FileUrlHelper.Generate(data.User.File.FilePath),
                    ParentCommentId = data.ParentCommentId,
                    CommentId = data.Id,
                    UserId = data.UserId,
                    Comment = data.Comment,
                    CreatedDate = data.CreatedDate,
                    NotUsefulRating = data.CommentRatings.Where(x => x.Useful == false && x.DeletedDate == null).Count(),
                    UsefulRating = data.CommentRatings.Where(x => x.Useful == true && x.DeletedDate == null).Count()
                };

                commentDatas.Add(commentForAdminDto);
            }

            ResultCommentForAdminDto response = new();
            response.CommentForAdminDtos = commentDatas;
            response.CommentsCount = await _commentReadRepository.GetWhere(x => x.BookId == request.BookId && x.DeletedDate == null).CountAsync();


            return new SuccessDataResponse<ResultCommentForAdminDto>(response);
        }
    }
}