using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FileHelpers.Abstract
{
    public interface ICustomerAvatarFileService
    {
        string SetDefaultCustomerAvatar();
        string UpdateCustomerAvatar(IFormFile file,string beforeAvatarName);
        string UploadCustomerAvatar(IFormFile file);
        void  DeleteCustomerAvatar(string avatarName);
    }
}