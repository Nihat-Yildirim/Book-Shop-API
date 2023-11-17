using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAddressByUserAndAddressId
{
    public class GetAddressByUserAndAddressIdQueryHandler : IRequestHandler<GetAddressByUserAndAddressIdQueryRequest, BaseDataResponse<AddressDto>>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        public GetAddressByUserAndAddressIdQueryHandler(IAddressReadRepository addressReadRepository)
        {
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseDataResponse<AddressDto>> Handle(GetAddressByUserAndAddressIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedAddress = await _addressReadRepository.Table
                                  .Include(x => x.Neighbourhood)
                                  .Include(x => x.Province)
                                  .Include(x => x.District)
                                  .SingleOrDefaultAsync(x => x.UserId == request.UserId && x.Id == request.AddressId && x.DeletedDate == null);

            if(selectedAddress == null ) 
                return new SuccessDataResponse<AddressDto>();

            AddressDto response = new()
            {
                Id = request.AddressId,
                OpenAddress = selectedAddress.OpenAddress,
                AddressTitle = selectedAddress.AddressTitle,
                Description = selectedAddress.Description,
                Selected = selectedAddress.Selected,
                PhoneNumber = selectedAddress.PhoneNumber,
                District = new()
                {
                    Id = selectedAddress.District.Id,
                    Name = selectedAddress.District.Name
                },
                Province = new()
                {
                    Id = selectedAddress.Province.Id,
                    Name = selectedAddress.Province.Name
                },
                Neighbourhood = new()
                {
                    Id = selectedAddress.Neighbourhood.Id,
                    Name = selectedAddress.Neighbourhood.Name
                },
                
            };

            return new SuccessDataResponse<AddressDto>(response);
        }
    }
}