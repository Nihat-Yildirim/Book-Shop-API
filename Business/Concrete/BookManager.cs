using AutoMapper;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using Entities.DTOs.BookPictureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        IMapper _mapper;
        public BookManager(IBookDal bookDal,IMapper mapper)
        {
            _mapper = mapper;
            _bookDal = bookDal;
        }

        [ValidationAspect(typeof(AddBookDtoValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IBookService.Get")]
        [PerformanceAspect(15)]
        public IDataResult<Book> Add(AddBookDto addedBookDto)
        {
            var businessResult = BusinessRules.Run(CheckBookNameExistInTheStore(addedBookDto.BookName, addedBookDto.StoreId));

            if (!businessResult.Success)
                return new ErrorDataResult<Book>();

            var addedBook = _mapper.Map<Book>(addedBookDto);
            addedBook.CreatedDate = DateTime.Now;
            addedBook.Status = true;
            _bookDal.Add(addedBook);

            var addedBookResult = _bookDal.Get(b => b.StoreId == addedBookDto.StoreId && b.BookName == addedBookDto.BookName);
            
            return new SuccessDataResult<Book>(addedBookResult);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<BookDetailDto>> GetAllBookDetail()
        {
            var resultBookDetails = _bookDal.GetAllBookDetail();

            return new SuccessDataResult<List<BookDetailDto>>(resultBookDetails);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<BookDetailDto>> GetAllBookDetailByStoreName(string storeName)
        {
            var resultBookDetails = _bookDal.GetAllBookDetail(b => b.StoreName == storeName);

            return new SuccessDataResult<List<BookDetailDto>>(resultBookDetails);
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<Book> GetBookById(int id)
        {
            var resultBook = _bookDal.Get(b => b.Id == id);

            return new SuccessDataResult<Book>(resultBook);
        }

        [ValidationAspect(typeof(UpdateBookDtoValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IBookService.Get")]
        [PerformanceAspect(15)]
        public IResult UpdateBook(UpdateBookDto updatedBookDto)
        {
            var beforeBook = GetBookById(updatedBookDto.BookId);

            if (!beforeBook.Success)
                return new ErrorResult("Kitap bilgileri güncellenemedi !");

            var updatedBook = _mapper.Map<Book>(updatedBookDto);
            updatedBook.Status = beforeBook.Data.Status;
            updatedBook.StoreId = beforeBook.Data.StoreId;
            updatedBook.CreatedDate = beforeBook.Data.CreatedDate;

            _bookDal.Update(updatedBook);

            return new SuccessResult();
        }

        private IResult CheckBookNameExistInTheStore(string bookName, int storeId)
        {
            var result = _bookDal.Get(b => b.StoreId == storeId && b.BookName == bookName);

            if (result != null)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}