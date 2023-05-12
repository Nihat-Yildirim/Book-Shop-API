using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.BookPictureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class BookPictureProfile : Profile
    {
        public BookPictureProfile()
        {
            CreateMap<UpdateBookPictureDto,BookPicture>()
                .ForMember(destination => destination.BookId, operation => operation.MapFrom(source => source.BookId))
                .ForMember(destination => destination.Id, operation => operation.MapFrom(source => source.BookPictureId));
        }
    }
}