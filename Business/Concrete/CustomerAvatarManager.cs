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

        public IResult DeleteCustomerAvatar(Customer customer)
        {
            var resultCustomerAvatar = _customerAvatarDal.Get(a => a.CustomerId == customer.Id);
            _fileService.Delete(resultCustomerAvatar.FileId);
            return new SuccessResult();
        }

        public IResult SetDefaultCustomerAvatar(Customer customer)
        {
            var resultFiles = _strogeService.GetFiles(LocalStrogePathConstants.CustomerDefaultAvatarsPath);
            var resultFile = resultFiles[RandomTool.GenerateRandomNumberInRange(0, resultFiles.Count)];
            var file = new File
            {
                FileName = resultFile.Name,
                FilePath = resultFile.FullName,
                FileExtension = resultFile.Extension,
                StorageName = _strogeService.StrogeName,
                UploadDate = DateTime.Now,
            };
            var result = _fileService.Add(file);

            var customerAvatar = new CustomerAvatar
            {
                CustomerId = customer.Id,
                FileId = result.Data.Id
            };

            _customerAvatarDal.Add(customerAvatar);
            return new SuccessResult();
        }

        public IResult UpdateCustomerAvatar(IFormFile avatar, Customer customer)
        {
            var beforeAvatar = _customerAvatarDal.Get(a => a.CustomerId == customer.Id);
            var beforeFile = _fileService.GetFileByFileId(beforeAvatar.FileId).Data;
            _fileService.Update(avatar, beforeFile, LocalStrogePathConstants.CustomerAvatarsPath);
            
            return new SuccessResult();
        }
    }
}