using Business.Abstract;
using Business.Constants.PathConstants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using File = Entities.Concrete.File;
using Core.Utilities.Business;
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
using Castle.Core.Resource;
using Entities.DTOs.CustomerDTOs;
using AutoMapper;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Claims;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IFileService _fileService;
        IStorageService _storageService;
        IUserClaimService _userClaimService;
        IMapper _mapper;
        public CustomerManager(
            IUserClaimService userClaimService,
            ICustomerDal customerDal, 
            IFileService fileService, 
            IStorageService storageService,
            IMapper mapper)
        {
            _userClaimService = userClaimService;
            _customerDal = customerDal;
            _fileService = fileService;
            _storageService = storageService;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        [TransactionScopeAspect]
        [PerformanceAspect(15)]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            _userClaimService.Add(customer.UserId, Claims.Customer);
            
            return new SuccessResult();
        }

        [PerformanceAspect(15)]
        public IDataResult<Customer> GetByUserId(int userId)
        {
            var resultCustomer = _customerDal.Get(c => c.UserId == userId);

            return new SuccessDataResult<Customer>(resultCustomer);
        }

        [PerformanceAspect(15)]
        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            var resultCustomer = _customerDal.Get(c => c.Id == customerId);

            return new SuccessDataResult<Customer>(resultCustomer);
        }

        [PerformanceAspect(15)]
        public IDataResult<CustomerDetailDto> GetCustomerDetailById(int customerId)
        {
            var resultCustomerDetail = _customerDal.GetCustomerDetail(c => c.CustomerId == customerId);

            return new SuccessDataResult<CustomerDetailDto>(resultCustomerDetail);
        }

        [PerformanceAspect(15)]
        public IDataResult<CustomerDetailDto> GetCustomerDetailsByEmail(string email)
        {
            var resultCustomerDetail = _customerDal.GetCustomerDetail(c => c.Email == email);

            return new SuccessDataResult<CustomerDetailDto>(resultCustomerDetail);
        }

        [SecuredOperation("Customer")]
        [TransactionScopeAspect]
        [PerformanceAspect(20)]
        public IResult AddCustomerAvatar(int customerId, IFormFile avatar)
        {
            var resultCustomer = _customerDal.Get(c => c.Id == customerId);
            var resultStorage = _storageService.UploadFile(avatar, LocalStoragePathConstants.CustomerAvatarsPath);

            var file = _mapper.Map<File>(resultStorage);
            file.Status = true;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;

            var resultFile = _fileService.Add(file);

            resultCustomer.FileId = resultFile.Data.Id;
            _customerDal.Update(resultCustomer);

            return new SuccessResult();

        }

        [SecuredOperation("Customer")]
        [TransactionScopeAspect]
        [PerformanceAspect(20)]
        public IResult UpdateCustomerAvatar(int customerId, IFormFile avatar)
        {
            var resultCustomer = _customerDal.Get(c => c.Id == customerId);
            var resultFile = _fileService.GetFileByFileId(resultCustomer.FileId).Data;
            var resultStorage = _storageService.UpdateFile(avatar, resultFile.FilePath, LocalStoragePathConstants.CustomerAvatarsPath);

            var file = _mapper.Map<File>(resultStorage);
            file.Id = resultFile.Id;
            file.Status = resultFile.Status;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;

            _fileService.Update(file);

            return new SuccessResult();
        }

        [SecuredOperation("Customer")]
        [TransactionScopeAspect]
        [PerformanceAspect(15)]
        public IResult DeleteCustomerAvatar(int customerId)
        {
            var resultCustomer = _customerDal.Get(c => c.Id == customerId);
            var resultFile = _fileService.GetFileByFileId(resultCustomer.FileId).Data;

            _storageService.Delete(resultFile.FilePath);
            _fileService.Delete(resultFile);

            return new SuccessResult();
        }
    }
}