using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookForAdminById
{
    public class GetBookForAdminByIdQueryHandler : IRequestHandler<GetBookForAdminByIdQueryRequest, BaseDataResponse<BookForAdminDto>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBookForAdminByIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<BookForAdminDto>> Handle(GetBookForAdminByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _bookReadRepository.GetSingleBookForAdminDtoAsync(x => x.Id == request.Id);
            return new SuccessDataResponse<BookForAdminDto>(responseData);
        }
    }
}