using AutoMapper;
using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddress
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, BaseDataResponse<List<AddressForAdminDto>>>
    {
        private readonly IAddressReadRepository _addressReadRepository;

        public GetAllAddressQueryHandler(IAddressReadRepository addressReadRepository)
        {
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseDataResponse<List<AddressForAdminDto>>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var addresses = await _addressReadRepository.Table.Include(x => x.Province)
                                                                    .Include(x => x.District)
                                                                    .Include(x => x.Neighbourhood)
                                                                    .AsNoTracking()
                                                                    .ToListAsync();

            List<AddressForAdminDto> response = new();
            foreach(var address in addresses)
            {
                AddressForAdminDto addressForAdmin = new();
                addressForAdmin.Id = address.Id;
                addressForAdmin.AddressTitle = address.AddressTitle;
                addressForAdmin.OpenAddress = address.OpenAddress;
                addressForAdmin.Description = address.Description;
                addressForAdmin.Selected = address.Selected;
                addressForAdmin.CreatedDate = address.CreatedDate;
                addressForAdmin.UpdatedDate = address.UpdatedDate;
                addressForAdmin.DeletedDate = address.DeletedDate;
                addressForAdmin.Province = new()
                {
                    Id = address.Province.Id,
                    Name = address.Province.Name,
                };
                addressForAdmin.District = new()
                {
                    Id = address.District.Id,
                    Name = address.District.Name,
                };
                addressForAdmin.Neighbourhood = new()
                {
                    Id = address.Neighbourhood.Id,
                    Name = address.Neighbourhood.Name,
                };
            }

            return new SuccessDataResponse<List<AddressForAdminDto>>(response);
        }
    }
}