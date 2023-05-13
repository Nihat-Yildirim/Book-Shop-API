using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(FileValidator))]
        [CacheRemoveAspect("IFileService.Get")]
        public IDataResult<File> Add(File file)
        {
            _fileDal.Add(file);
            var result = GetFileByFilePath(file.FilePath);
            return new SuccessDataResult<File>(result.Data);
        }

        [ValidationAspect(typeof(FileValidator))]
        [CacheRemoveAspect("IFileService.Get")]
        public IResult Delete(File file)
        {
            _fileDal.Delete(file);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(FileValidator))]
        [CacheRemoveAspect("IFileService.Get")]
        public IResult Update(File file)
        {
            _fileDal.Update(file);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<File> GetFileByFileId(int fileId)
        {
            var result = _fileDal.Get(f => f.Id == fileId);
            return new SuccessDataResult<File>(result);
        }

        [CacheAspect]
        public IDataResult<File> GetFileByFileName(string fileName)
        {
            var result = _fileDal.Get(f => f.FileName == fileName); 
            return new SuccessDataResult<File>(result);
        }

        [CacheAspect]
        public IDataResult<File> GetFileByFilePath(string filePathOrContainerName)
        {
            var result = _fileDal.Get(f => f.FilePath == filePathOrContainerName);
            return new SuccessDataResult<File>(result);
        }
    }
}