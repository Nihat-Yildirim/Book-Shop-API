﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs.StoreDTOs;
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
        IDataResult<List<StoreDetailDto>> GetAllStoreDetail();
        IDataResult<Store> GetById(int id);
        IResult Add(Store store, IFormFile file);
        IResult UpdateLogo(Store store, IFormFile file);
        IResult UpdateStoreName(int storeId,string name);
        IResult UpdateStoreDescription(int storeId,string newDescription);
        IResult CheckStoreNameExists(string storeName);
        IResult Delete(int storeId);
    }
}