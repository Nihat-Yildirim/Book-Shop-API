using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPattern
{
    public class GetAuthorByPatternQueryHandler : IRequestHandler<GetAuthorByPatternQueryRequest, BaseDataResponse<List<ShortAuthorDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAuthorByPatternQueryHandler(IAuthorReadRepository authorReadRepository, IMapper mapper)
        {
            _authorReadRepository = authorReadRepository;
            _mapper = mapper;
        }

        public async Task<BaseDataResponse<List<ShortAuthorDto>>> Handle(GetAuthorByPatternQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _authorReadRepository
                          .GetWhere(x => x.DeletedDate == null && x.Name.ToUpper().StartsWith(request.Pattern.ToUpper()), false)
                          .Select(x => new ShortAuthorDto{
                             Id = x.Id,
                             Name = x.Name,
                          })
                          .ToListAsync();

            return new SuccessDataResponse<List<ShortAuthorDto>>(response);
        }
    }
}