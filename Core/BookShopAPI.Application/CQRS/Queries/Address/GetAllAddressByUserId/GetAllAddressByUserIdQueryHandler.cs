using AutoMapper;
using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Address.GetAllAddressByUserId
{
    public class GetAllAddressByUserIdQueryHandler : IRequestHandler<GetAllAddressByUserIdQueryRequest, BaseDataResponse<List<GetAddressDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAddressReadRepository _addressReadRepository;

        public GetAllAddressByUserIdQueryHandler(IAddressReadRepository addressReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseDataResponse<List<GetAddressDto>>> Handle(GetAllAddressByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var addresses = await _addressReadRepository.GetWhere(x => x.UserId == request.UserId && x.DeletedDate == null , false).ToListAsync();
            
            var responseAddresses = _mapper.Map<List<GetAddressDto>>(addresses);

            return new SuccessDataResponse<List<GetAddressDto>>(responseAddresses);
        }
    }
}