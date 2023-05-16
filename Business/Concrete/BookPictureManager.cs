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
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Business;
using System.Text.RegularExpressions;
using Core.DTOs.StorageDTOs;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class BookPictureManager : IBookPictureService
    {
        IMapper _mapper;
        IFileService _fileService;
        IBookPictureDal _bookPictureDal;
        IStorageService _storageService;
        public BookPictureManager(IBookPictureDal bookPictureDal, IFileService fileService, IStorageService storageService, IMapper mapper)
        {
            _mapper = mapper;
            _fileService = fileService;
            _bookPictureDal = bookPictureDal;
            _storageService = storageService;
        }

        [ValidationAspect(typeof(AddBookPictureDtoValidator))]
        [CacheRemoveAspect("IBookService.Get")]
        [CacheRemoveAspect("IBookPictureService.Get")]
        [PerformanceAspect(20)]
        public IResult Add(AddBookPictureDto addedBookPictureDto)
        {
            var businessResult = BusinessRules.Run(CheckBookPictures(addedBookPictureDto.BookId));

            if (!businessResult.Success)
                return new ErrorResult("Kitap resim sınırına ulaşıldı lütfen resimlerinizi güncellemeyi deneyiniz !");


            var bookPictures = _bookPictureDal.GetAll(p => p.BookId == addedBookPictureDto.BookId);
            int addedPictureLenght = 5 - bookPictures.Count;
            var addedPictures = addedBookPictureDto.BookPictures.ToList();

            addedPictures.Reverse();
            addedPictures.RemoveRange(0, addedPictures.Count - addedPictureLenght);
            addedPictures.Reverse();

            var storageResults = _storageService.UploadFiles(addedPictures, LocalStoragePathConstants.BookPicturesPath);
            if (bookPictures.Count == 0)
                Add(storageResults, addedBookPictureDto.BookId);
            else if (bookPictures.Count != 5)
                Add(storageResults, addedBookPictureDto.BookId, bookPictures.Count);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(UpdateBookPictureDtoValidator))]
        [CacheRemoveAspect("IBookService.Get")]
        [CacheRemoveAspect("IBookPictureService.Get")]
        [PerformanceAspect(20)]
        public IResult Update(UpdateBookPictureDto updatedBookPictureDto)
        {
            var beforeBookPicture = _bookPictureDal.Get(p => p.Id == updatedBookPictureDto.BookPictureId);

            var updatedPicture = _mapper.Map<BookPicture>(updatedBookPictureDto);
            updatedPicture.OrderOfAppearance = beforeBookPicture.OrderOfAppearance;
            updatedPicture.FileId = beforeBookPicture.FileId;

            var beforeBookPictureFile = _fileService.GetFileByFileId(beforeBookPicture.FileId).Data;

            var storageResult = _storageService.UpdateFile(updatedBookPictureDto.NewBookPicture, beforeBookPictureFile.FilePath, LocalStoragePathConstants.BookPicturesPath);

            var updatedFile = _mapper.Map<File>(storageResult);
            updatedFile.Status = beforeBookPictureFile.Status;
            updatedFile.UploadDate = DateTime.Now;
            updatedFile.StorageName = _storageService.StorageName;
            updatedFile.Id = beforeBookPictureFile.Id;

            _fileService.Update(updatedFile);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(UpdateBookPictureOrderOfAppearanceDtoValidator))]
        [CacheRemoveAspect("IBookService.Get")]
        [CacheRemoveAspect("IBookPictureService.Get")]
        [PerformanceAspect(20)]
        public IResult UpdateBookPictureOrderOfAppearance(UpdateBookPictureOrderOfAppearanceDto updateBookPictureOrderOfAppearance)
        {
            var resultBeforeBookPicture = _bookPictureDal.Get(
                p => p.BookId == updateBookPictureOrderOfAppearance.BookId &&
                p.Id == updateBookPictureOrderOfAppearance.PictureId);

            var resultGoalBookPicture = _bookPictureDal.Get(
                p => p.BookId == updateBookPictureOrderOfAppearance.BookId &&
                p.OrderOfAppearance == updateBookPictureOrderOfAppearance.OrderOfAppearance);

            resultGoalBookPicture.OrderOfAppearance = resultBeforeBookPicture.OrderOfAppearance;
            resultBeforeBookPicture.OrderOfAppearance = updateBookPictureOrderOfAppearance.OrderOfAppearance;

            _bookPictureDal.Update(resultGoalBookPicture);
            _bookPictureDal.Update(resultBeforeBookPicture);

            return new SuccessResult();
        }

        private void Add(List<ResultFileInfoDto> storageResults, int bookId, int orderOfAppearance = 1)
        {
            foreach (var storageResult in storageResults)
            {
                var file = _mapper.Map<File>(storageResult);
                file.Status = true;
                file.StorageName = _storageService.StorageName;
                file.UploadDate = DateTime.Now;

                var resultFile = _fileService.Add(file);

                BookPicture addedBookPicture = new()
                {
                    BookId = bookId,
                    FileId = resultFile.Data.Id,
                    OrderOfAppearance = orderOfAppearance
                };

                _bookPictureDal.Add(addedBookPicture);

                if (orderOfAppearance == 5)
                    break;

                orderOfAppearance++;
            }
        }

        private IResult CheckBookPictures(int bookId)
        {
            var resultPictures = _bookPictureDal.GetAll(p => p.BookId == bookId);

            if (resultPictures.Count == 5)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}