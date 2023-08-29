using BookShopAPI.Application.DTOs.StorageDTOs;
using BookShopAPI.Application.Storage;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Infrastructure.Storages
{
    public class LocalStorage : IStorage
    {
        public void Delete(string filePath)
        {
            if(File.Exists(filePath)) 
                File.Delete(filePath);  
        }

        public void DeleteRange(List<string> filePaths)
        {
            filePaths.ForEach(filePath =>
            {
                Delete(filePath);
            });
        }

        public Task<List<string>> GetFileNamesAsync(string path)
        {
            if (Directory.Exists(path))
                return Task.FromResult(Directory.GetFiles(path).ToList());

            return default;
        }

        public Task<bool> HasFileAsync(string fileName, string path)
        {
            if(!Directory.Exists(Path.Combine(path, fileName))) 
                return Task.FromResult(false);

            return Task.FromResult(true);
        }

        public async Task<ResultFileInfoDto> UpdateFileAsync(IFormFile file, string beforeFilePath, string path)
        {
            Delete(beforeFilePath);
            return await UploadFileAsync(file, path);
        }

        public async Task<List<ResultFileInfoDto>> UpdateFilesAsync(IFormFileCollection files, List<string> beforeFilePaths, string path)
        {
            List<ResultFileInfoDto> resultFileInfos = new();

            if (files.Count != beforeFilePaths.Count)
                throw new Exception("Files count equal file path");

            for (int i = 0; i < files.Count; i++)
            {
                var result = await UpdateFileAsync(files[i], beforeFilePaths[i], path);
                resultFileInfos.Add(result);
            }

            return resultFileInfos;
        }

        public async Task<ResultFileInfoDto> UploadFileAsync(IFormFile file, string path)
        {
            if (file.Length == 0)
                return default;

            if (Directory.Exists(path))
                Directory.CreateDirectory(path);

            string extension = Path.GetExtension(file.FileName);
            string guid = Guid.NewGuid().ToString();
            string newFileName = guid + extension;

            using(FileStream fileStream = File.Create(Path.Combine(path, newFileName)))
            {
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
            }

            return new()
            {
                FileName = newFileName,
                FileExtension = extension,
                FilePath = Path.Combine(path, newFileName)
            };
        }

        public async Task<List<ResultFileInfoDto>> UploadFilesAsync(IFormFileCollection files, string path)
        {
            List<ResultFileInfoDto> resultFileInfos = new();

            foreach(IFormFile file in files)
            {
                var resultFileInfo = await UploadFileAsync(file, path);
                resultFileInfos.Add(resultFileInfo);
            }

            return resultFileInfos;
        }
    }
}