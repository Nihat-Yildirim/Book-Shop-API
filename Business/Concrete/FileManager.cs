using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Entities.Concrete.File;

namespace Business.Concrete
{
    public class FileManager : IFileService
    {
        IFileDal _fileDal;
        IStorageService _storageService;
        public FileManager(IFileDal fileDal,IStorageService storageService)
        {
            _fileDal= fileDal;
            _storageService= storageService;
        }

        public IDataResult<File> Add(IFormFile formFile, string pathOrContainerName)
        {
            var result = _storageService.UploadFile(formFile, pathOrContainerName);
            var file = new File
            {
                FileName = result.fileName,
                FileExtension = result.fileExtension,
                FilePath = result.filePathOrContainerName,
                StorageName = _storageService.StrogeName,
                UploadDate = DateTime.Now
            };
            _fileDal.Add(file);
            var returnFile = GetFileByFilePath(result.fileName);

            return new SuccessDataResult<File>(returnFile.Data);
        }

        public IDataResult<File> Add(File file)
        {
            _fileDal.Add(file);
            var result = GetFileByFilePath(file.FilePath);
            return new SuccessDataResult<File>(result.Data);
        }

        public IResult Delete(File file)
        {
            _fileDal.Delete(file);
            _storageService.Delete(file.FilePath);
            return new SuccessResult();
        }

        public IResult Delete(int fileId)
        {
            var result = GetFileByFileId(fileId);
            _fileDal.Delete(result.Data);
            return new SuccessResult();
        }

        public IDataResult<File> GetFileByFileId(int fileId)
        {
            var result = _fileDal.Get(f => f.Id == fileId);
            return new SuccessDataResult<File>(result);
        }

        public IDataResult<File> GetFileByFileName(string fileName)
        {
            var result = _fileDal.Get(f => f.FileName == fileName); 
            return new SuccessDataResult<File>(result);
        }

        public IDataResult<File> GetFileByFilePath(string filePathOrContainerName)
        {
            var result = _fileDal.Get(f => f.FilePath == filePathOrContainerName);
            return new SuccessDataResult<File>(result);
        }

        public IDataResult<File> Update(IFormFile formFile, File file, string pathOrContainerName)
        {
            var result = _storageService.UpdateFile(formFile,file.FilePath,pathOrContainerName);
            file.FilePath = result.filePathOrContainerName;
            file.FileName = result.fileName;
            file.StorageName = _storageService.StrogeName;
            file.FileExtension = result.fileExtension;
            _fileDal.Update(file);

            return new SuccessDataResult<File>(file);
        }
    }
}