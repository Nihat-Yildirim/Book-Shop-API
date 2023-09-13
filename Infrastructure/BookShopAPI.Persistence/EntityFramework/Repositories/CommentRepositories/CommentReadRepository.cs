using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CommendRepositories
{
    public class CommentReadRepository : BaseReadRepository<CommentEntity>, ICommentReadRepository
    {
        public CommentReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<List<CommentDto>> GetCommentDtosAsync(Expression<Func<CommentEntity, bool>> filter = null)
        {
            IQueryable<CommentEntity> query;
            query = Table.Include(x => x.CommentRatings);

            List<CommentEntity> datas = new();

            if (filter != null)
                datas = await query.AsNoTracking().Where(filter).ToListAsync();

            if (filter == null)
                datas = await query.AsNoTracking().ToListAsync();

            List<CommentDto> responseCommentDtos = new();

            foreach (var data in datas)
            {
                CommentDto commentDto = new()
                {
                    CommentId = data.Id,
                    Comment = data.Comment,
                    TotalRating = data.CommentRatings.Where(x => x.DeletedDate == null).Count(),
                    TotalUsefulRating = data.CommentRatings.Where(x => x.Useful == true && x.DeletedDate == null).Count(),
                    TotalNotUsefulRating = data.CommentRatings.Where(x => x.Useful == false && x.DeletedDate == null).Count(),
                };

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