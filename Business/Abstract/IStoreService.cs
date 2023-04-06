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
    public interface IStoreService
    {
        IDataResult<Store> GetByStoreName(string storeName);
        IDataResult<Store> GetById(int id);
        IResult Add(Store store, IFormFile file);
        IResult Delete(Store store);
        IResult UpdateLogo(Store store, IFormFile file);
        IResult UpdateStoreInformation(Store store);
    }
}