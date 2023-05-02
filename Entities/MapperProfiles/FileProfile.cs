using AutoMapper;
using Core.DTOs.StorageDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Entities.Concrete.File;

namespace Entities.MapperProfiles
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            CreateMap<ResultFileInfoDto, File>()
                .ForMember(destination => destination.FileName, operation => operation.MapFrom(source => source.FileName))
                .ForMember(destination => destination.FilePath, operation => operation.MapFrom(source => source.FilePathOrContainerName))
                .ForMember(destination => destination.FileExtension, operation => operation.MapFrom(source => source.FileExtension));
        }
    }
}