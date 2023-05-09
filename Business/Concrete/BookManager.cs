using AutoMapper;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
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

        [ValidationAspect(typeof(AddedBookDtoValidator))]
        public IDataResult<Book> Add(AddedBookDto addedBookDto)
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

        private IResult CheckBookNameExistInTheStore(string bookName, int storeId)
        {
            var result = _bookDal.Get(b => b.StoreId == storeId && b.BookName == bookName);

            if (result != null)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}