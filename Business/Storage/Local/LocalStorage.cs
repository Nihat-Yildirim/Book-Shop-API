using Core.DTOs.StorageDTOs;
using Core.Utilities.Helpers.GuidHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Storage;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Stroge.Local
{
    public class LocalStorage : IStorage
    {
        public void Delete(string beforeFilePath)
        {
            if (File.Exists(beforeFilePath))
                File.Delete(beforeFilePath);
        }

        public FileInfo GetFile(string fileName, string path)
        {
            var result = GetFiles(path);
            var file = result.FirstOrDefault(f => f.Name == fileName);

            if (file != null)
                return file;

            return null;
        }

        public List<string> GetFileNames(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetFiles(path).ToList();
           
            return null;
        }

        public List<FileInfo> GetFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var resultFiles = directoryInfo.GetFiles();
            if (resultFiles.Length != 0)
                return resultFiles.ToList();
           
            return null;
        }

        public bool HasFile(string fileName, string path)
        {
            var resultFileNames = GetFileNames(path);

            if (resultFileNames != null && resultFileNames.Contains(Path.Combine(path, fileName)))
                return true;
           
            return false;
        }

        public ResultFileInfoDto UpdateFile(IFormFile file, string beforeFilePath, string path)
        {
            Delete(beforeFilePath);
            return UploadFile(file, path);
        }

        public List<ResultFileInfoDto> UpdateFiles(List<IFormFile> files, List<string> beforeFilePaths, string path)
        {
            List<ResultFileInfoDto> values = new();

            if (files.Count == beforeFilePaths.Count)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    var result = UpdateFile(files[i], beforeFilePaths[i], path);

                    if (result != default)
                        values.Add(result);
                }
                return values;
            }
            else
            {
                throw new Exception("Gönderilen Dosya İle Dosya Yolu Aynı Adette Olmalıdır !!");
            }
        }

        public ResultFileInfoDto UploadFile(IFormFile file, string path)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string extension = Path.GetExtension(file.FileName);
                string guid = GuidTool.CreateNewGuid();
                string newFileName = guid + extension;

                using (FileStream fileStream = File.Create(path + newFileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }

                var resultFileInfo = new ResultFileInfoDto
                {
                    FileName = newFileName,
                    FileExtension = extension,
                    FilePathOrContainerName = Path.Combine(path, newFileName)
                };

                return resultFileInfo;
            }

            return default;
        }

        public List<ResultFileInfoDto> UploadFiles(List<IFormFile> files, string path)
        {
            List<ResultFileInfoDto> values = new();

            foreach (IFormFile file in files)
            {
                var result = UploadFile(file, path);

                if (result != default)
                    values.Add(result);
            }

            return values;
        }
    }
}