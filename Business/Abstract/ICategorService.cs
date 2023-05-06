using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategorService
    {
        IResult Add(Category category);
        IResult UpdateCategoryName(Category category);
        IDataResult<List<Category>> GetAllCategories();
    }
}