using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants.PathConstants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.PublisherDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Entities.Concrete.File;

namespace Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;
        IFileService _fileService;
        IStorageService _storageService;
        IMapper _mapper;
        public PublisherManager(
            IPublisherDal publisherDal, 
            IFileService fileService,
            IStorageService storageService,
            IMapper mapper)
        {
            _mapper = mapper;
            _publisherDal = publisherDal;
            _fileService = fileService;
            _storageService = storageService;
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(AddPublisherDtoValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IPublisherService.Get")]
        [PerformanceAspect(15)]
        public IResult Add(AddPublisherDto addedPublisher)
        {
            var businessResult = BusinessRules.Run(CheckIfPublisherNameExists(addedPublisher.Name));

            if (businessResult.Success != true)
                return new ErrorResult();

            var storageResult = _storageService.UploadFile(addedPublisher.Logo, LocalStoragePathConstants.PublisherLogosPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = true;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;

            var fileResult = _fileService.Add(file);

            var publisher = new Publisher
            {
                FileId = fileResult.Data.Id,
                Name = addedPublisher.Name,
                Status = true
            };

            _publisherDal.Add(publisher);

            return new SuccessResult();
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(PublisherValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IPublisherService.Get")]
        [PerformanceAspect(20)]
        public IResult Update(UpdatePublisherDto updatedPublisher)
        {
            var beforePublisher = _publisherDal.Get(p => p.Id ==  updatedPublisher.Id);
            var beforeFile = _fileService.GetFileByFileId(beforePublisher.FileId).Data;

            var storageResult = _storageService.UpdateFile(updatedPublisher.Logo, beforeFile.FilePath, LocalStoragePathConstants.PublisherLogosPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = beforeFile.Status;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;
            file.Id = beforeFile.Id;

            var publisher = new Publisher
            {
                Id = beforePublisher.Id,
                Name = updatedPublisher.Name,
                Status = true,
                FileId = file.Id,
            };

            _fileService.Update(file);
            _publisherDal.Update(publisher);

            return new SuccessResult();
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(PublisherValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IPublisherService.Get")]
        [PerformanceAspect(20)]
        public IResult Delete(Publisher publisher)
        {
            var resultFile = _fileService.GetFileByFileId(publisher.FileId).Data;

            resultFile.Status = false;
            publisher.Status = false;

            _fileService.Update(resultFile);
            _publisherDal.Update(publisher);

            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<PublisherDetailDto>> GetAll()
        {
            var result = _publisherDal.GetAllPublisherDetails();

            return new SuccessDataResult<List<PublisherDetailDto>>(result);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<PublisherDetailDto> GetByName(string name)
        {
            var result = _publisherDal.GetPublisherDetail(p => p.Name == name);

            return new SuccessDataResult<PublisherDetailDto>(result);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<PublisherDetailDto> GetById(int id)
        {
            var result = _publisherDal.GetPublisherDetail(p => p.Id == id);

            return new SuccessDataResult<PublisherDetailDto>(result);
        }

        private IResult CheckIfPublisherNameExists(string publisherName)
        {
            var resultPublisher = _publisherDal.Get(p => p.Name == publisherName);

            if (resultPublisher != null)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}