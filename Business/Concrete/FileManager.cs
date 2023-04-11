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
        public FileManager(IFileDal fileDal)
        {
            _fileDal= fileDal;
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

        public IResult Update(File file)
        {
            _fileDal.Update(file);
            return new SuccessResult();
        }
    }
}