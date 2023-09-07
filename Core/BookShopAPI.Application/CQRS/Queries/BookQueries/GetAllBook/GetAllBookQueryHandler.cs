using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBook
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetAllBookQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetAllBookQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _bookReadRepository.GetBookDtosAsync(new Pagination { Page = request.Page , Size = request.Size});
            return new SuccessDataResponse<List<BookDto>>(response);
        }
    }
}