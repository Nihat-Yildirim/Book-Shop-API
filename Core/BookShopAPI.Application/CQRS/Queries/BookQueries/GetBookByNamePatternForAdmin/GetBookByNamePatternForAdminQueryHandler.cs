using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePatternForAdmin
{
    public class GetBookByNamePatternForAdminQueryHandler : IRequestHandler<GetBookByNamePatternForAdminQueryRequest, BaseDataResponse<List<BookForAdminDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBookByNamePatternForAdminQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookForAdminDto>>> Handle(GetBookByNamePatternForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _bookReadRepository.GetBookForAdminDtosAsync(new Pagination { Page = request.Page, Size = request.Size }, x => x.BookName.Contains(request.Pattern));
            return new SuccessDataResponse<List<BookForAdminDto>>(responseDatas);
        }
    }
}