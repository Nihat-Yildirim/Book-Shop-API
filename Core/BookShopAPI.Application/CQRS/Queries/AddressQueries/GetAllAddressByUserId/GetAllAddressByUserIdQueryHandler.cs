using AutoMapper;
using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddressByUserId
{
    public class GetAllAddressByUserIdQueryHandler : IRequestHandler<GetAllAddressByUserIdQueryRequest, BaseDataResponse<List<AddressDto>>>
    {
        private readonly IAddressReadRepository _addressReadRepository;

        public GetAllAddressByUserIdQueryHandler(IAddressReadRepository addressReadRepository)
        {
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseDataResponse<List<AddressDto>>> Handle(GetAllAddressByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var addresses = await _addressReadRepository.Table.Include(x => x.Province)
                                                              .Include(x => x.District)
                                                              .Include(x => x.Neighbourhood)
                                                              .Where(x => x.UserId == request.UserId && x.DeletedDate == null)
                                                              .AsNoTracking()
                                                              .ToListAsync();

            List<AddressDto> response = new();
            foreach (var address in addresses) 
            {
                AddressDto addressDto = new();
                addressDto.Id = address.Id;
                addressDto.PhoneNumber = address.PhoneNumber;
                addressDto.AddressTitle = address.AddressTitle;
                addressDto.Description = address.Description;
                addressDto.OpenAddress = address.OpenAddress;
                addressDto.Selected = address.Selected;
                addressDto.Province = new()
                {
                    Id = address.Province.Id,
                    Name = address.Province.Name,
                };
                addressDto.District = new()
                {
                    Id = address.District.Id,
                    ProvinceId = address.District.ProvinceId,
                    Name=address.District.Name, 
                };
                addressDto.Neighbourhood = new()
                {
                    Id = address.Neighbourhood.Id,
                    DistrictId = address.Neighbourhood.DistrictId,
                    Name = address.Neighbourhood.Name,
                };

                response.Add(addressDto);
            }

            return new SuccessDataResponse<List<AddressDto>>(response);

        }
    }
}