using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Stroge
{
    public interface IStorage
    {
        List<(string fileName, string filePathOrContainerName, string fileExtension)> UploadFiles(IFormFileCollection files, string pathOrContainerName);
        (string fileName, string filePathOrContainerName, string fileExtension) UploadFile(IFormFile file, string pathOrContainerName);
        List<(string fileName, string filePathOrContainerName, string fileExtension)> UpdateFiles(IFormFileCollection files, List<string> beforeFilePathOrContainerNames, string pathOrContainerName);
        (string fileName, string filePathOrContainerName, string fileExtension) UpdateFile(IFormFile file, string beforeFilePathOrContainerName, string pathOrContainerName);
        bool HasFile(string fileName,string pathOrContainerName);
        void Delete(string fileName, string pathOrContainerName);
        void Delete(string beforeFilePathOrContainerName);
        List<string> GetFileNames(string pathOrContainerName);
        List<FileInfo> GetFiles(string pathOrContainerName);
        FileInfo GetFile(string fileName , string pathOrContainerName);
    }
}