using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPattern
{
    public class GetAuthorByPatternQueryHandler : IRequestHandler<GetAuthorByPatternQueryRequest, BaseDataResponse<List<AuthorDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAuthorByPatternQueryHandler(IAuthorReadRepository authorReadRepository, IMapper mapper)
        {
            _authorReadRepository = authorReadRepository;
            _mapper = mapper;
        }

        public async Task<BaseDataResponse<List<AuthorDto>>> Handle(GetAuthorByPatternQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorReadRepository
                .GetWhere(x => x.DeletedDate == null && x.FirstName.Contains(request.Pattern) || x.LastName.Contains(request.Pattern), false)
                .Include(x => x.File)
                .ToListAsync();
            var responseAuthors = _mapper.Map<List<AuthorDto>>(authors);

            return new SuccessDataResponse<List<AuthorDto>>(responseAuthors);
        }
    }
}