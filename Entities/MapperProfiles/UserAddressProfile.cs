using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.CustomerDTOs;
using Entities.DTOs.UserAddressDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class UserAddressProfile : Profile
    {
        public UserAddressProfile()
        {
            CreateMap<BaseAddedUserAddressDto, UserAddress>()
                .ForMember(destination => destination.AddressTitle, operation => operation.MapFrom(source => source.AddressTitle))
                .ForMember(destination => destination.Description, operation => operation.MapFrom(source => source.Description))
                .ForMember(destination => destination.Province, operation => operation.MapFrom(source => source.Province))
                .ForMember(destination => destination.District, operation => operation.MapFrom(source => source.District))
                .ForMember(destination => destination.Neighbourhood, operation => operation.MapFrom(source => source.Neighbourhood))
                .ForMember(destination => destination.Address, operation => operation.MapFrom(source => source.Address));

            CreateMap<BaseUpdatedUserAddressDto, UserAddress>()
                .ForMember(destination => destination.Id, operation => operation.MapFrom(source => source.AddressId))
                .ForMember(destination => destination.AddressTitle, operation => operation.MapFrom(source => source.AddressTitle))
                .ForMember(destination => destination.Description, operation => operation.MapFrom(source => source.Description))
                .ForMember(destination => destination.Province, operation => operation.MapFrom(source => source.Province))
                .ForMember(destination => destination.District, operation => operation.MapFrom(source => source.District))
                .ForMember(destination => destination.Neighbourhood, operation => operation.MapFrom(source => source.Neighbourhood))
                .ForMember(destination => destination.Address, operation => operation.MapFrom(source => source.Address));
        }
    }
}
