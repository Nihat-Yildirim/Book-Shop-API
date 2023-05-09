using AutoMapper;
using Business.Abstract;
using Business.Constants.PathConstants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Storage;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BookPictureDTOs;
using File = Entities.Concrete.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class BookPictureManager : IBookPictureService
    {
        IBookPictureDal _bookPictureDal;
        IFileService _fileService;
        IStorageService _storageService;
        IMapper _mapper;
        public BookPictureManager(IBookPictureDal bookPictureDal, IFileService fileService, IStorageService storageService, IMapper mapper)
        {
            _bookPictureDal = bookPictureDal;
            _fileService = fileService;
            _storageService = storageService;
            _mapper = mapper;
        }

        public IResult Add(AddedBookPictureDto addedBookPictureDto)
        {
            bool isShow = true;
            var storageResults = _storageService.UploadFiles(addedBookPictureDto.BookPictures, LocalStoragePathConstants.BookPicturesPath);

            foreach(var storageResult in storageResults)
            {
                var file = _mapper.Map<File>(storageResult);
                file.Status = true;
                file.StorageName = _storageService.StorageName;
                file.UploadDate = DateTime.Now;

                var resultFile = _fileService.Add(file);

                BookPicture addedBookPicture = new()
                {
                    BookId = addedBookPictureDto.BookId,
                    FileId = resultFile.Data.Id,
                };

                addedBookPicture.Show = false;

                if(isShow)
                {
                    isShow = false;
                    addedBookPicture.Show = true;
                }

                _bookPictureDal.Add(addedBookPicture);
            }
            
            return new SuccessResult();
        }

    }
}