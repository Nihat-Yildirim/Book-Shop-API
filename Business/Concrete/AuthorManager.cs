using Business.Abstract;
using Business.Constants.PathConstants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;
        IFileService _fileService;
        IStorageService _storageService;

        public AuthorManager(IAuthorDal authorDal,IFileService fileService,IStorageService storageService)
        {
            _authorDal = authorDal;
            _fileService = fileService;
            _storageService = storageService;
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Add(Author author, IFormFile formFile)
        {
            var businessResult = BusinessRules.Run(CheckIfAuthorExists(author.FirstName, author.LastName));
            if (!businessResult.Success)
                return new ErrorResult(businessResult.Message);

            var storageResult = _storageService.UploadFile(formFile, LocalStoragePathConstants.AuthorPicturesPath);

            var file = new File
            {
                FileName = storageResult.fileName,
                FileExtension = storageResult.fileExtension,
                FilePath = storageResult.filePathOrContainerName,
                StorageName = _storageService.StorageName,
                UploadDate = DateTime.Now,
                Status = true
            };

            var resultFile = _fileService.Add(file);
            author.FileId = resultFile.Data.Id;

            _authorDal.Add(author);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Delete(Author author)
        {
            var fileResut = _fileService.GetFileByFileId(author.FileId);

            _storageService.Delete(fileResut.Data.FilePath);
            _authorDal.Delete(author);  

            return new SuccessResult();
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Update(Author author,IFormFile formFile)
        {
            var beforeFile = _fileService.GetFileByFileId(author.FileId).Data;
            var storageResult = _storageService.UpdateFile(formFile, beforeFile.FilePath, LocalStoragePathConstants.AuthorPicturesPath);

            var file = new File
            {
                Id = beforeFile.Id,
                FileExtension = storageResult.fileExtension,
                FileName = storageResult.fileName,
                FilePath = storageResult.filePathOrContainerName,
                StorageName = _storageService.StorageName,
                UploadDate = DateTime.Now,
                Status = true
            };

            _fileService.Update(file);
            _authorDal.Update(author);
            return new SuccessResult();
        }

        public IDataResult<List<Author>> GetAll()
        {
            var result = _authorDal.GetAll();
            return new SuccessDataResult<List<Author>>(result);
        }

        public IDataResult<Author> GetById(int Id)
        {
            var result = _authorDal.Get(a => a.Id == Id);
            return new SuccessDataResult<Author>(result);
        }

        public IDataResult<Author> GetByName(string name)
        {
            var result = _authorDal.Get(a => a.FirstName == name);
            return new SuccessDataResult<Author>(result);
        }

        private IResult CheckIfAuthorExists(string authorName,string authorLastName)
        {
            var resultAuthor = _authorDal.Get(a => a.FirstName ==  authorName && a.LastName == authorLastName);

            if (resultAuthor != null)
                return new ErrorResult("Böyle bir yazar zaten mevcut !");

            return new SuccessResult();
        }
    }
}