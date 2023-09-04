using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByPatternForAdmin
{
    public class GetAuthorByPatternForAdminQueryHandler : IRequestHandler<GetAuthorByPatternForAdminQueryRequest, BaseDataResponse<List<AuthorForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAuthorByPatternForAdminQueryHandler(IMapper mapper, IAuthorReadRepository authorReadRepository)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<List<AuthorForAdminDto>>> Handle(GetAuthorByPatternForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorReadRepository
                .GetWhere(x => x.FirstName.Contains(request.Pattern) || x.LastName.Contains(request.Pattern), false)
                .Include(x => x.File)
                .ToListAsync();

            var responseAuthors = _mapper.Map<List<AuthorForAdminDto>>(authors);

            return new SuccessDataResponse<List<AuthorForAdminDto>>(responseAuthors);
        }
    }
}