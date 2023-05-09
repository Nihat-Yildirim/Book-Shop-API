using Core.Utilities.Results.Abstract;
using Entities.DTOs.BookOfCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookOfCategoryService
    {
        IResult Add(AddedBookOfCategoryDto addedBookOfCategory);
    }
}