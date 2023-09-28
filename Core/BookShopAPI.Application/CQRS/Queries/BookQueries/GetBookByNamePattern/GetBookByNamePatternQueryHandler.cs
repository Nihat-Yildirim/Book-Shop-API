using AutoMapper;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePattern
{
    public class GetBookByNamePatternQueryHandler : IRequestHandler<GetBookByNamePatternQueryRequest, BaseDataResponse<List<ShortBookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IMapper _mapper;

        public GetBookByNamePatternQueryHandler(IBookReadRepository bookReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortBookDto>>> Handle(GetBookByNamePatternQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _bookReadRepository.GetWhere(x => x.DeletedDate == null && x.BookName.StartsWith(request.Pattern))
                .Skip(request.Page * request.Size).Take(request.Size).ToListAsync();

            var responseBooks = _mapper.Map<List<ShortBookDto>>(responseDatas);
            return new SuccessDataResponse<List<ShortBookDto>>(responseBooks);
        }
    }
}