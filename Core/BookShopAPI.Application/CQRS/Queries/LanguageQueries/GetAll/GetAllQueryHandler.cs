using BookShopAPI.Application.DTOs.LanguageDTOs;
using BookShopAPI.Application.Repositories.LanguageRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.LanguageQueries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, BaseDataResponse<List<LanguageDto>>>
    {
        private readonly ILanguageReadRepository _languageReadRepository;

        public GetAllQueryHandler(ILanguageReadRepository languageReadRepository)
        {
            _languageReadRepository = languageReadRepository;
        }

        public async Task<BaseDataResponse<List<LanguageDto>>> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            var datas = await _languageReadRepository.GetAll(false).ToListAsync();
            
            List<LanguageDto> response = new();
            foreach(var data in datas)
                response.Add(new LanguageDto
                {
                    Name = data.Name,
                    Id = data.Id,
                });

            return new SuccessDataResponse<List<LanguageDto>>(response);
        }
    }
}