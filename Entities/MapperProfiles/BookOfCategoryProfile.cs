using AutoMapper;
using Azure;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using Entities.DTOs.BookOfCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class BookOfCategoryProfile : Profile
    {
        public BookOfCategoryProfile()
        {
            CreateMap<AddedBookDto, AddedBookOfCategoryDto>()
                .ForMember(destination => destination.CategoryIds, operation => operation.MapFrom(source => source.CategoryIds));

            CreateMap<AddedBookOfCategoryDto, BookOfCategory>()
                .ForMember(destination => destination.BookId, operation => operation.MapFrom(source => source.BookId));
        }
    }
}
