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
using AutoMapper;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;
        IFileService _fileService;
        IStorageService _storageService;
        IMapper _mapper;

        public AuthorManager(
            IAuthorDal authorDal,
            IFileService fileService,
            IStorageService storageService,
            IMapper mapper)
        {
            _authorDal = authorDal;
            _fileService = fileService;
            _storageService = storageService;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(AuthorValidator))]
        [CacheRemoveAspect("IAuthorService.Get")]
        public IResult Add(Author author, IFormFile formFile)
        {
            var businessResult = BusinessRules.Run(CheckIfAuthorExists(author.FirstName, author.LastName));
            if (!businessResult.Success)
                return new ErrorResult(businessResult.Message);

            var storageResult = _storageService.UploadFile(formFile, LocalStoragePathConstants.AuthorPicturesPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = true;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;

            var resultFile = _fileService.Add(file);
            author.FileId = resultFile.Data.Id;
            author.Status = true;

            _authorDal.Add(author);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(AuthorValidator))]
        [CacheRemoveAspect("IAuthorService.Get")]
        public IResult Delete(Author author)
        {
            var fileResult = _fileService.GetFileByFileId(author.FileId).Data;

            fileResult.Status = false;
            author.Status = false;

            _fileService.Update(fileResult);
            _authorDal.Update(author);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(AuthorValidator))]
        [CacheRemoveAspect("IAuthorService.Get")]
        public IResult Update(Author author,IFormFile formFile)
        {
            var beforeFile = _fileService.GetFileByFileId(author.FileId).Data;
            var storageResult = _storageService.UpdateFile(formFile, beforeFile.FilePath, LocalStoragePathConstants.AuthorPicturesPath);

            var file = _mapper.Map<File>(storageResult);
            file.Status = beforeFile.Status;
            file.StorageName = _storageService.StorageName;
            file.UploadDate = DateTime.Now;
            file.Id = beforeFile.Id;

            author.Status = true;

            _fileService.Update(file);
            _authorDal.Update(author);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Author>> GetAll()
        {
            var result = _authorDal.GetAll();
            return new SuccessDataResult<List<Author>>(result);
        }

        [CacheAspect]
        public IDataResult<Author> GetById(int Id)
        {
            var result = _authorDal.Get(a => a.Id == Id);
            return new SuccessDataResult<Author>(result);
        }

        [CacheAspect]
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