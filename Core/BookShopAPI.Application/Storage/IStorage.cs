using BookShopAPI.Application.DTOs.StorageDTOs;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Storage
{
    public interface IStorage
    {
        Task<ResultFileInfoDto> UploadFileAsync(IFormFile file, string pathOrContainerName);
        Task<List<ResultFileInfoDto>> UploadFilesAsync(IFormFileCollection files, string pathOrContainerName);
        Task<ResultFileInfoDto> UpdateFileAsync(IFormFile file, string beforeFilePathOrContainerName, string pathOrContainerName);
        Task<List<ResultFileInfoDto>> UpdateFilesAsync(IFormFileCollection files, List<string> beforeFilePathOrContainerNames, string pathOrContainerName);
        Task<List<string>> GetFileNamesAsync(string pathOrContainerName);
        Task<bool> HasFileAsync(string fileName,string pathOrContainerName);
        void DeleteRange(List<string> filesPathOrContainerNames);
        void Delete(string pathOrContainerName);
    }
}