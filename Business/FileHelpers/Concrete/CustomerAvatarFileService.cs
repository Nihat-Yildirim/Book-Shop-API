using Business.Constants;
using Business.FileHelpers.Abstract;
using Core.Utilities.Helpers.GuidHelper;
using Core.Utilities.Helpers.RandomHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FileHelpers.Concrete
{
    public class CustomerAvatarFileService : ICustomerAvatarFileService
    {
        public void DeleteCustomerAvatar(string avatarFileName)
        {
            var resultDefaultAvatars = GetFiles(PathConstants.CustomerDefaultAvatarsPath);
            if (!resultDefaultAvatars.Contains(avatarFileName))
            {
                var avatarPath = PathConstants.CustomerAvatarsPath + avatarFileName;
                if (File.Exists(avatarPath))
                {
                    File.Delete(avatarPath);
                }
            }
        }

        public string SetDefaultCustomerAvatar()
        {
            var resultAvatars = GetFiles(PathConstants.CustomerDefaultAvatarsPath);
            string currentDefaultAvatar = resultAvatars[RandomTool.GenerateRandomNumberInRange(0, resultAvatars.Count)];
            return currentDefaultAvatar;
        }

        public string UpdateCustomerAvatar(IFormFile file,string beforeAvatarName)
        {
            if(file.Length > 0)
            {
                DeleteCustomerAvatar(beforeAvatarName);
                return UploadCustomerAvatar(file);
            }
            return null;
        }

        public string UploadCustomerAvatar(IFormFile file)
        {
            if(file.Length > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                string guid = GuidTool.CreateNewGuid();
                string avatarFileName = guid + extension;

                using(FileStream fileStream = File.Create(PathConstants.CustomerAvatarsPath + avatarFileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                return avatarFileName;
            }
            return null;
        }

        private List<string> GetFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var resultFiles = directoryInfo.GetFiles().ToList();
            List<string> files = resultFiles.Select(f =>f.Name).ToList();
            return files;
        }
    }
}