using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IResult Add(Author author, IFormFile formFile);
        IResult Update(Author author, IFormFile formFile);
        IResult Delete(Author author);  
        IDataResult<List<Author>> GetAll();
        IDataResult<Author> GetByName(string name);
        IDataResult<Author> GetById(int Id);
    }
}