using Castle.Components.DictionaryAdapter.Xml;
using Core.Utilities.Storage;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Stroge
{
    public class StorageManager : IStorageService
    {
        IStorage _stroge;

        public StorageManager(IStorage stroge)
        {
            _stroge = stroge;
        }

        public string StorageName { get { return "LocalStorage"; } }

        public void Delete(string fileName, string pathOrContainerName)
        {
            _stroge.Delete(fileName, pathOrContainerName);
        }

        public void Delete(string beforeFilePathOrContainerName)
        {
            _stroge.Delete(beforeFilePathOrContainerName);
        }

        public FileInfo GetFile(string fileName, string pathOrContainerName)
        {
            return _stroge.GetFile(fileName, pathOrContainerName);
        }

        public List<string> GetFileNames(string pathOrContainerName)
        {
            return _stroge.GetFileNames(pathOrContainerName);
        }

        public List<FileInfo> GetFiles(string pathOrContainerName)
        {
            return _stroge.GetFiles(pathOrContainerName);
        }

        public bool HasFile(string fileName, string pathOrContainerName)
        {
            return _stroge.HasFile(fileName, pathOrContainerName);
        }

        public (string fileName, string filePathOrContainerName, string fileExtension) UpdateFile(IFormFile file, string beforeFilePathOrContainerName, string pathOrContainerName)
        {
            return _stroge.UpdateFile(file, beforeFilePathOrContainerName, pathOrContainerName);
        }

        public List<(string fileName, string filePathOrContainerName, string fileExtension)> UpdateFiles(IFormFileCollection files, List<string> beforeFilePathOrContainerNames, string pathOrContainerName)
        {
            return _stroge.UpdateFiles(files, beforeFilePathOrContainerNames, pathOrContainerName);
        }

        public (string fileName, string filePathOrContainerName, string fileExtension) UploadFile(IFormFile file, string pathOrContainerName)
        {
            return _stroge.UploadFile(file, pathOrContainerName);
        }

        public List<(string fileName, string filePathOrContainerName, string fileExtension)> UploadFiles(IFormFileCollection files, string pathOrContainerName)
        {
            return _stroge.UploadFiles(files, pathOrContainerName);
        }
    }
}
