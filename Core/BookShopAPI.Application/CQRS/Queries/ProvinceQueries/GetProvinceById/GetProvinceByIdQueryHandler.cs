using AutoMapper;
using BookShopAPI.Application.DTOs.ProvinceDTOs;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetProvinceById
{
    public class GetProvinceByIdQueryHandler : IRequestHandler<GetProvinceByIdQueryRequest, BaseDataResponse<ProvinceDto>>
    {
        private readonly IMapper _mapper;
        private readonly IProvinceReadRepository _provinceReadRepository;

        public GetProvinceByIdQueryHandler(IMapper mapper, IProvinceReadRepository provinceReadRepository)
        {
            _mapper = mapper;
            _provinceReadRepository = provinceReadRepository;
        }

        public async Task<BaseDataResponse<ProvinceDto>> Handle(GetProvinceByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedProvince = await _provinceReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.Id);
            var response = _mapper.Map<ProvinceDto>(selectedProvince);

            return new SuccessDataResponse<ProvinceDto>(response);
        }
    }
}