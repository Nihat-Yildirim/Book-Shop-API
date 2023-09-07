using AutoMapper;
using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddress
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, BaseDataResponse<List<GetAddressForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAddressReadRepository _addressReadRepository;

        public GetAllAddressQueryHandler(IAddressReadRepository addressReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseDataResponse<List<GetAddressForAdminDto>>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var resultAddresses = await _addressReadRepository.GetAll(false).ToListAsync();
            var responseAddresses = _mapper.Map<List<GetAddressForAdminDto>>(resultAddresses);

            return new SuccessDataResponse<List<GetAddressForAdminDto>>(responseAddresses);
        }
    }
}