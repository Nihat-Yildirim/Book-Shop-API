using Core.Utilities.Helpers.GuidHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Stroge;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Stroge.Local
{
    public class LocalStroge : IStroge
    {
        public void Delete(string fileName, string path)
        {
            string filePath = Path.Combine(path, fileName);
            Delete(filePath);
        }

        public void Delete(string beforeFilePath)
        {
            if (File.Exists(beforeFilePath))
            {
                File.Delete(beforeFilePath);
            }
        }

        public FileInfo GetFile(string fileName, string path)
        {
            var result = GetFiles(path);
            var file = result.FirstOrDefault(f => f.Name == fileName);
            
            if (file != null)
            {
                return file;
            }

            return null;
        }

        public List<string> GetFileNames(string path)
        {
            if (Directory.Exists(path))
            {
                return Directory.GetFiles(path).ToList();
            }
            return null;
        }

        public List<FileInfo> GetFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var resultFiles = directoryInfo.GetFiles();
            if (resultFiles.Length != 0)
            {
                return resultFiles.ToList();
            }
            return null;
        }

        public bool HasFile(string fileName, string path)
        {
            var resultFileNames = GetFileNames(path);

            if (resultFileNames != null && resultFileNames.Contains(Path.Combine(path, fileName)))
            {
                return true;
            }
            return false;
        }

        public (string fileName, string filePathOrContainerName, string fileExtension) UpdateFile(IFormFile file, string beforeFilePath, string path)
        {
            Delete(beforeFilePath);
            return UploadFile(file, path);
        }

        public List<(string fileName, string filePathOrContainerName, string fileExtension)> UpdateFiles(IFormFileCollection files, List<string> beforeFilePaths, string path)
        {
            List<(string fileName, string filePathOrContainerName, string fileExtension)> values = new();

            if (files.Count == beforeFilePaths.Count)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    var result = UpdateFile(files[i], beforeFilePaths[i], path);

                    if (result != default)
                    {
                        values.Add(result);
                    }
                }
                return values;
            }
            else
            {
                throw new Exception("Gönderilen Dosya İle Dosya Yolu Aynı Adette Olmalıdır !!");
            }
        }

        public (string fileName, string filePathOrContainerName, string fileExtension) UploadFile(IFormFile file, string path)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string extension = Path.GetExtension(file.FileName);
                string guid = GuidTool.CreateNewGuid();
                string newFileName = guid + extension;

                using (FileStream fileStream = File.Create(path + newFileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                return (newFileName, Path.Combine(path, newFileName), extension);
            }

            return default;
        }

        public List<(string fileName, string filePathOrContainerName, string fileExtension)> UploadFiles(IFormFileCollection files, string path)
        {
            List<(string fileName, string filePathOrContainerName, string fileExtension)> values = new();

            foreach (IFormFile file in files)
            {
                var result = UploadFile(file, path);

                if (result != default)
                {
                    values.Add(result);
                }
            }

            return values;
        }
    }
}