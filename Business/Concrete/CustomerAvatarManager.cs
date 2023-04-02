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

namespace Business.Concrete
{
    public class CustomerAvatarManager : ICustomerAvatarService
    {
        IStorageService _strogeService;
        ICustomerAvatarDal _customerAvatarDal;
        public CustomerAvatarManager(IStorageService strogeService,ICustomerAvatarDal customerAvatarDal)
        {
            _strogeService= strogeService;  
            _customerAvatarDal= customerAvatarDal;
        }

        public IResult DeleteCustomerAvatar(Customer customer)
        {
            var resultAvatar = _customerAvatarDal.Get(a => a.CustomerId == customer.Id);
            _customerAvatarDal.Delete(resultAvatar);
            return new SuccessResult();
        }

        public IResult SetDefaultCustomerAvatar(Customer customer)
        {
            var defaultAvatars = _strogeService.GetFiles(LocalStrogePathConstants.CustomerDefaultAvatarsPath);
            var currentAvatar = defaultAvatars[RandomTool.GenerateRandomNumberInRange(0, defaultAvatars.Count)];

            var customerAvatar = new CustomerAvatar
            {
                CustomerId= customer.Id,
                AvatarFileExtension = currentAvatar.Extension,
                AvatarFileName = currentAvatar.Name,
                AvatarFilePath = currentAvatar.FullName,
                StorageName = _strogeService.StrogeName,
                UploadDate = DateTime.Now,
            };

            _customerAvatarDal.Add(customerAvatar);
            return new SuccessResult();
        }

        public IResult UpdateCustomerAvatar(IFormFile avatar, Customer customer)
        {
            var resultAvatar = _customerAvatarDal.Get(a => a.CustomerId == customer.Id);
            var resultFileInfo = _strogeService.UploadFile(avatar, LocalStrogePathConstants.CustomerAvatarsPath);

            if(resultFileInfo != default)
            {
                resultAvatar.AvatarFileExtension = resultFileInfo.fileExtension;
                resultAvatar.AvatarFileName = resultFileInfo.fileName;
                resultAvatar.AvatarFilePath = resultFileInfo.filePathOrContainerName;
                resultAvatar.StorageName = _strogeService.StrogeName;
                resultAvatar.UploadDate = DateTime.Now;

                _customerAvatarDal.Update(resultAvatar);
                return new SuccessResult("Kullanıcı avatarı güncellendi");
            }
            return new ErrorResult("Kullanıcı avatarı güncellenemedi");
        }
    }
}