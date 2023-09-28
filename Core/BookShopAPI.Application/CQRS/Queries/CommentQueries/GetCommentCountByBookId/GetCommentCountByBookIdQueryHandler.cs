using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentCountByBookId
{
    public class GetCommentCountByBookIdQueryHandler : IRequestHandler<GetCommentCountByBookIdQueryRequest, BaseDataResponse<CountDto>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetCommentCountByBookIdQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseDataResponse<CountDto>> Handle(GetCommentCountByBookIdQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _commentReadRepository.GetWhere(x => x.BookId == request.BookId && x.DeletedDate == null, tracing: false).CountAsync();
            return new SuccessDataResponse<CountDto>(new CountDto()
            {
                Count = result,
            });
        }
    }
}