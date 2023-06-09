﻿using Castle.Components.DictionaryAdapter.Xml;
using Core.DTOs.StorageDTOs;
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

        public StorageManager(IStorage storage)
        {
            _stroge = storage;
        }

        public string StorageName { get { return "LocalStorage"; } }

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

        public ResultFileInfoDto UpdateFile(IFormFile file, string beforeFilePathOrContainerName, string pathOrContainerName)
        {
            return _stroge.UpdateFile(file, beforeFilePathOrContainerName, pathOrContainerName);
        }

        public List<ResultFileInfoDto> UpdateFiles(List<IFormFile> files, List<string> beforeFilePathOrContainerNames, string pathOrContainerName)
        {
            return _stroge.UpdateFiles(files, beforeFilePathOrContainerNames, pathOrContainerName);
        }

        public ResultFileInfoDto UploadFile(IFormFile file, string pathOrContainerName)
        {
            return _stroge.UploadFile(file, pathOrContainerName);
        }

        public List<ResultFileInfoDto> UploadFiles(List<IFormFile> files, string pathOrContainerName)
        {
            return _stroge.UploadFiles(files, pathOrContainerName);
        }
    }
}