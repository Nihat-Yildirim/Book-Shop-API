using Business.Abstract;
using Business.Constants.PathConstants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using File = Entities.Concrete.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class StoreManager : IStoreService
    {
        IStoreDal _storeDal;
        IFileService _fileService;
        IStorageService _storageService;
        public StoreManager(IStoreDal storeDal,IStorageService storageService,IFileService fileService)
        {
            _storageService= storageService;
            _storeDal = storeDal;
            _fileService= fileService;
        }

        public IResult Add(Store store, IFormFile formfile)
        {
            var businessResult = BusinessRules.Run(CheckIfStoreNameExists(store.Name));
            
            if (!businessResult.Success)
                return new ErrorResult();

            var result = _storageService.UploadFile(formfile, LocalStoragePathConstants.StoreLogoPath);
            
            var file = new File
            {
                FileName = result.fileName,
                FileExtension = result.fileExtension,
                FilePath = result.filePathOrContainerName,
                StorageName = _storageService.StrogeName,
                UploadDate = DateTime.Now,
            };

            var resultFile = _fileService.Add(file);

            var addedStore = new Store
            {
                Name = store.Name,
                Description = store.Description,
                FileId= resultFile.Data.Id,
                Status = true
            };

            _storeDal.Add(addedStore);
            
            return new SuccessResult();
        }

        public IResult Delete(Store store)
        {
            var resultStore = _storeDal.Get(s => s.Name == store.Name); 
            _storeDal.Delete(resultStore);

            var resultFile = _fileService.GetFileByFileId(resultStore.FileId);
            _fileService.Delete(resultFile.Data);

            return new SuccessResult();
        }

        public IDataResult<Store> GetById(int id)
        {
            var resultStore = _storeDal.Get(s=>s.Id == id);
            return new SuccessDataResult<Store>(resultStore);
        }

        public IDataResult<Store> GetByStoreName(string storeName)
        {
            var resultStore = _storeDal.Get(s => s.Name == storeName);
            return new SuccessDataResult<Store>(resultStore);
        }

        public IResult UpdateLogo(Store store, IFormFile formFile)
        {
            var resultBeforeFile = _fileService.GetFileByFileId(store.FileId).Data;
            var resultFile = _storageService.UpdateFile(formFile, resultBeforeFile.FilePath, LocalStoragePathConstants.StoreLogoPath);
            
            var file = new File
            {
                Id= store.FileId,
                FileExtension = resultFile.fileExtension,
                FileName = resultFile.fileName,
                FilePath = resultFile.filePathOrContainerName,
                StorageName = _storageService.StrogeName,
                UploadDate = DateTime.Now,
            };
            
            _fileService.Update(file);
            return new SuccessResult();
        }

        public IResult UpdateStoreInformation(Store store)
        {
            var result = BusinessRules.Run(CheckIfStoreNameExists(store.Name));
            if (!result.Success)
                return new ErrorResult();

            _storeDal.Update(store);
            return new SuccessResult();
        }

        private IResult CheckIfStoreNameExists(string storeName)
        {
            var resultStore = _storeDal.Get(s => s.Name == storeName);
            if (resultStore == null)
                return new SuccessResult();

            return new ErrorResult();
        }
    }
}