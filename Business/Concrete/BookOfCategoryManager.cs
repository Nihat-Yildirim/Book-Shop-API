using AutoMapper;
using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BookOfCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookOfCategoryManager : IBookOfCategoryService
    {
        IBookOfCategoryDal _bookOfCategoryDal;
        IMapper _mapper;
        public BookOfCategoryManager(IBookOfCategoryDal bookOfCategoryDal,IMapper mapper)
        {
            _bookOfCategoryDal = bookOfCategoryDal;
            _mapper = mapper;
        }

        [CacheRemoveAspect("IBookOfCategoryService.Get")]
        [TransactionScopeAspect]
        [CacheRemoveAspect("IBookService.Get")]
        [PerformanceAspect(15)]
        public IResult Add(AddBookOfCategoryDto addedBookOfCategories)
        {
            foreach (var categoryId in addedBookOfCategories.CategoryIds)
            {
                var addedBookCategory = _mapper.Map<BookOfCategory>(addedBookOfCategories);
                addedBookCategory.CategoryId = categoryId;

                _bookOfCategoryDal.Add(addedBookCategory);
            }
            return new SuccessResult();
        }
    }
}