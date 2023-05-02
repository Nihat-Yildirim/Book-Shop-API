using AutoMapper;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserForRegisterDto, User>()
                .ForMember(destination => destination.FirstName, operation => operation.MapFrom(source => source.FirstName))
                .ForMember(destination => destination.LastName, operation => operation.MapFrom(source => source.LastName))
                .ForMember(destination => destination.Email, operation => operation.MapFrom(source => source.Email));
        }
    }
}
