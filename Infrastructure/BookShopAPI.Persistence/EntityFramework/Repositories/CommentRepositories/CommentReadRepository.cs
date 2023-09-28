using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CommendRepositories
{
    public sealed class CommentReadRepository : BaseReadRepository<CommentEntity>, ICommentReadRepository
    {
        public CommentReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<List<CommentDto>> GetCommentDtosAsync(Pagination pagination, int userId, Expression<Func<CommentEntity, bool>> filter = null)
        {
            IQueryable<CommentEntity> query;
            query = Table.Include(x => x.CommentRatings)
                         .Include(x => x.User)
                            .ThenInclude(x => x.File);

            List<CommentEntity> datas = new();

            if (filter != null)
                datas = query.AsNoTracking()
                        .Where(filter)
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size).ToList();

            if (filter == null)
                datas = query.AsNoTracking()
                        .Skip(pagination.Page * pagination.Size)
                        .Take(pagination.Size).ToList();

            List<CommentDto> responseCommentDtos = new();
            foreach (var data in datas)
            {
                CommentDto commentDto = new()
                {
                    UserId = data.UserId,
                    CreatedDate = data.CreatedDate,
                    UserName = data.User.FirstName,
                    UserPictureUrl = FileUrlHelper.Generate(data.User.File.FilePath),
                    CommentId = data.Id,
                    Comment = data.Comment,
                    TotalUsefulRating = data.CommentRatings.Where(x => x.Useful == true && x.DeletedDate == null).Count(),
                    TotalNotUsefulRating = data.CommentRatings.Where(x => x.Useful == false && x.DeletedDate == null).Count(),
                };

                if (commentDto.UserId != userId || data.CommentRatings.Count == 0)
                    commentDto.SelectedCommentRating = UserSelectCommentRating.None;

                var selectedCommetRating = data.CommentRatings.SingleOrDefault(x => x.UserId == userId);
                if (selectedCommetRating != null && selectedCommetRating.Useful)
                    commentDto.SelectedCommentRating = UserSelectCommentRating.Useful;

                if(selectedCommetRating != null && selectedCommetRating.Useful == false)
                    commentDto.SelectedCommentRating = UserSelectCommentRating.NotUseful;

                responseCommentDtos.Add(commentDto);
            }
            return responseCommentDtos;
        }

        public async Task<List<CommentForAdminDto>> GetCommentForAdminDtosAsync(Pagination pagination, Expression<Func<CommentEntity, bool>> filter = null)
        {
            IQueryable<CommentEntity> query;
            query = Table.Include(x => x.CommentRatings)
                    .Skip(pagination.Page * pagination.Size)
                    .Take(pagination.Size);

            List<CommentEntity> datas = new();
            if (filter == null)
                datas = await query.AsNoTracking().ToListAsync();

            if (filter != null)
                datas = await query.AsNoTracking().Where(filter).ToListAsync();

            List<CommentForAdminDto> responseDatas = new();

            foreach (var data in datas)
            {
                CommentForAdminDto commentForAdminDto = new()
                {
                    BookId = data.BookId,
                    ParentCommentId = data.ParentCommentId,
                    CommentId = data.Id,
                    UserId = data.UserId,
                    Comment = data.Comment,
                    CreatedDate = data.CreatedDate,
                    DeletedDate = data.DeletedDate,
                    UpdatedDate = data.UpdatedDate,
                    TotalRating = data.CommentRatings.Where(x => x.DeletedDate == null).Count(),
                    TotalNotUsefulRating = data.CommentRatings.Where(x => x.Useful == false && x.DeletedDate == null).Count(),
                    TotalUsefulRating = data.CommentRatings.Where(x => x.Useful == true && x.DeletedDate == null).Count()
                };

                responseDatas.Add(commentForAdminDto);
            }

            return responseDatas;
        }
    }
}