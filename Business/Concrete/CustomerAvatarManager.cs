using Business.Abstract;
using Business.Constants.PathConstants;
using Core.Entities.Concrete;
using Core.Utilities.Helpers.RandomHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Entities.Concrete.File;

namespace Business.Concrete
{
    public class CustomerAvatarManager : ICustomerAvatarService
    {
        IFileService _fileService;
        IStorageService _strogeService;
        ICustomerAvatarDal _customerAvatarDal;
        public CustomerAvatarManager(
            IStorageService strogeService,
            ICustomerAvatarDal customerAvatarDal,
            IFileService fileService)
        {
            _strogeService = strogeService;
            _customerAvatarDal = customerAvatarDal;
            _fileService = fileService;
        }

        public IResult DeleteCustomerAvatar(int customerId)
        {
            var resultCustomerAvatar = _customerAvatarDal.Get(a => a.CustomerId == customerId);
            var deletedAvatarFile = _fileService.GetFileByFileId(resultCustomerAvatar.FileId).Data;

            _fileService.Delete(deletedAvatarFile.Id);
            _customerAvatarDal.Delete(resultCustomerAvatar);
            _strogeService.Delete(deletedAvatarFile.FilePath);
            return new SuccessResult();
        }

        public IResult AddCustomerAvatar(IFormFile avatar,int customerId)
        {
            var resultFile = _strogeService.UploadFile(avatar, LocalStoragePathConstants.CustomerAvatarsPath);
            var file = new File
            {
                FileName = resultFile.fileName,
                FilePath = resultFile.filePathOrContainerName,
                FileExtension = resultFile.fileExtension,
                StorageName = _strogeService.StrogeName,
                UploadDate = DateTime.Now,
                Status = true
            };
            var result = _fileService.Add(file);

            var customerAvatar = new CustomerAvatar
            {
                CustomerId = customerId,
                FileId = result.Data.Id
            };

            _customerAvatarDal.Add(customerAvatar);
            return new SuccessResult();
        }

        public IResult UpdateCustomerAvatar(IFormFile avatar, int customerId)
        {
            var beforeAvatar = _customerAvatarDal.Get(a => a.CustomerId == customerId);
            var beforeFile = _fileService.GetFileByFileId(beforeAvatar.FileId).Data;

            var resultFile = _strogeService.UpdateFile(avatar, beforeFile.FilePath, LocalStoragePathConstants.CustomerAvatarsPath);
            
            var file = new File
            {
                FileName = resultFile.fileName,
                FilePath = resultFile.filePathOrContainerName,
                FileExtension = resultFile.fileExtension,
                StorageName = _strogeService.StrogeName,
                UploadDate = DateTime.Now,
                Status = true,
                Id = beforeFile.Id
            };

            _fileService.Update(file);

            return new SuccessResult();
        }

        public IDataResult<CustomerAvatar> GetByCustomerId(int customerId)
        {
            var resultCustomerAvatar = _customerAvatarDal.Get(a => a.CustomerId == customerId);
            return new SuccessDataResult<CustomerAvatar>(resultCustomerAvatar);
        }
    }
}