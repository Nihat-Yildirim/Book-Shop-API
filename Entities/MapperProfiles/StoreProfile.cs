using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.DealerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<DealerForRegisterDto, Store>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.StoreName))
                .ForMember(destination => destination.Description, operation => operation.MapFrom(source => source.StoreDescription));
        }
    }
}
