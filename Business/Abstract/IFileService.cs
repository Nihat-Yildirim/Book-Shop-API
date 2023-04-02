using Core.Utilities.Results.Abstract;
using File = Entities.Concrete.File;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFileService
    {
        IDataResult<File> GetFileByFileId(int fileId);
        IDataResult<File> GetFileByFilePath(string filePathOrContainerName);
        IDataResult<File> GetFileByFileName(string fileName);
        IDataResult<File> Add(IFormFile formFile, string pathOrContainerName);
        IDataResult<File> Add(File file);
        IResult Delete(File file);
        IResult Delete(int fileId); 
        IDataResult<File> Update(IFormFile formFile,File file, string pathOrContainerName);
    }
}