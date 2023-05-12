using Core.DTOs.StorageDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Storage
{
    public interface IStorage
    {
        List<ResultFileInfoDto> UploadFiles(List<IFormFile> files, string pathOrContainerName);
        ResultFileInfoDto UploadFile(IFormFile file, string pathOrContainerName);
        List<ResultFileInfoDto> UpdateFiles(List<IFormFile> files, List<string> beforeFilePathOrContainerNames, string pathOrContainerName);
        ResultFileInfoDto UpdateFile(IFormFile file, string beforeFilePathOrContainerName, string pathOrContainerName);
        bool HasFile(string fileName,string pathOrContainerName);
        void Delete(string beforeFilePathOrContainerName);
        List<string> GetFileNames(string pathOrContainerName);
        List<FileInfo> GetFiles(string pathOrContainerName);
        FileInfo GetFile(string fileName , string pathOrContainerName);
    }
}