using AutoMapper.Configuration.Annotations;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
using Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategorService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("ICategorService.Get")]
        [PerformanceAspect(15)]
        public IResult Add(Category category)
        {
            var businessResult = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (!businessResult.Success)
                return new ErrorResult();

            _categoryDal.Add(category);

            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(15)]
        public IDataResult<List<Category>> GetAllCategories()
        {
            var resultCategories = _categoryDal.GetAll();

            return new SuccessDataResult<List<Category>>(resultCategories);
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("ICategorService.Get")]
        [PerformanceAspect(15)]
        public IResult UpdateCategoryName(Category category)
        {
            var businessResult = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (!businessResult.Success)
                return new ErrorResult();

            _categoryDal.Update(category);

            return new SuccessResult();
        }

        private IResult CheckIfCategoryNameExists(string categoryName)
        {
            var resultCategories = _categoryDal.Get(c => c.CategoryName ==  categoryName);

            if (resultCategories != null)
                return new ErrorResult();

            return new SuccessResult();
        }
    }
}