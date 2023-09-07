using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBookForAdmin
{
    public class GetAllBookForAdminQueryHandler : IRequestHandler<GetAllBookForAdminQueryRequest, BaseDataResponse<List<BookForAdminDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetAllBookForAdminQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookForAdminDto>>> Handle(GetAllBookForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _bookReadRepository.GetBookForAdminDtosAsync(new Pagination { Page = request.Page, Size = request.Size });
            return new SuccessDataResponse<List<BookForAdminDto>>(responseDatas);
        }
    }
}