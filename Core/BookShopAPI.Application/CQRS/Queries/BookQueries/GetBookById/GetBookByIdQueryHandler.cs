using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQueryRequest, BaseDataResponse<BookDto>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBookByIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<BookDto>> Handle(GetBookByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _bookReadRepository.GetSingleBookDtoAsync(x => x.Id == request.Id);
            return new SuccessDataResponse<BookDto>(responseData);
        }
    }
}