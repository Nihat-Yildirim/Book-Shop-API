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
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using AutoMapper;
using Entities.DTOs.StoreDTOs;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;

namespace Business.Concrete
{
    public class StoreManager : IStoreService
    {
        IStoreDal _storeDal;
        IFileService _fileService;
        IStorageService _storageService;
        IMapper _mapper;
        public StoreManager(
            IStoreDal storeDal, 
            IStorageService storageService, 
            IFileService fileService,
            IMapper mapper)
        {
            _storageService = storageService;
            _storeDal = storeDal;
            _fileService = fileService;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(StoreValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IStoreService.Get")]
        [PerformanceAspect(20)]
        public IResult Add(Store store, IFormFile formfile)
        {
            var businessResult = BusinessRules.Run(CheckStoreNameExists(store.Name));

            if (!businessResult.Success)
                return new ErrorResult();

            var storageResult = _storageService.UploadFile(formfile, LocalStoragePathConstants.StoreLogosPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = true;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;

            var resultFile = _fileService.Add(file);

            var addedStore = new Store
            {
                Name = store.Name,
                Description = store.Description,
                FileId = resultFile.Data.Id,
                Status = true
            };

            _storeDal.Add(addedStore);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(StoreValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IStoreService.Get")]
        [PerformanceAspect(20)]
        public IResult Delete(int storeId)
        {
            var resultStore = _storeDal.Get(s => s.Id == storeId);
            var resultFile = _fileService.GetFileByFileId(resultStore.FileId).Data;
            
            resultStore.Status = false;
            resultFile.Status = false;

            _storeDal.Update(resultStore);
            _fileService.Update(resultFile);

            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<Store> GetById(int id)
        {
            var resultStore = _storeDal.Get(s => s.Id == id);
            return new SuccessDataResult<Store>(resultStore);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<Store> GetByStoreName(string storeName)
        {
            var resultStore = _storeDal.Get(s => s.Name == storeName);
            return new SuccessDataResult<Store>(resultStore);
        }

        [ValidationAspect(typeof(StoreValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IStoreService.Get")]
        [PerformanceAspect(15)]
        public IResult UpdateLogo(Store store, IFormFile formFile)
        {
            var resultBeforeFile = _fileService.GetFileByFileId(store.FileId).Data;
            var storageResult = _storageService.UpdateFile(formFile, resultBeforeFile.FilePath, LocalStoragePathConstants.StoreLogosPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = true;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;
            file.Id = store.FileId;

            _fileService.Update(file);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(StoreValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IStoreService.Get")]
        [PerformanceAspect(15)]
        public IResult UpdateStoreDescription(int storeId, string newDescription)
        {
            var resultStore = _storeDal.Get(s => s.Id == storeId);
            resultStore.Description = newDescription;
            _storeDal.Update(resultStore);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(StoreValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IStoreService.Get")]
        [PerformanceAspect(15)]
        public IResult UpdateStoreName(int storeId, string name)
        {
            var result = BusinessRules.Run(CheckStoreNameExists(name));
            if (!result.Success)
                return new ErrorResult("Bu mağaza ismine ait zaten bir mağaza var !");

            var resultStore = _storeDal.Get(s => s.Id == storeId);
            resultStore.Name = name;

            _storeDal.Update(resultStore);

            return new SuccessResult("Mağaza ismi başarıyla güncellendi !");
        }

        [PerformanceAspect(15)]
        public IResult CheckStoreNameExists(string storeName)
        {
            var resultStore = _storeDal.Get(s => s.Name == storeName);

            if (resultStore == null)
                return new SuccessResult();

            return new ErrorResult();
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<StoreDetailDto>> GetAllStoreDetail()
        {
            var resultStoreDetailDto = _storeDal.GetAllStoreDetail();

            return new SuccessDataResult<List<StoreDetailDto>>(resultStoreDetailDto);
        }
    }
}