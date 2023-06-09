﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs.PublisherDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPublisherService
    {
        IResult Add(AddPublisherDto addedPublisher);
        IResult Update(UpdatePublisherDto updatedPublisher);
        IResult Delete(Publisher publisher);
        IDataResult<List<PublisherDetailDto>> GetAll();
        IDataResult<PublisherDetailDto> GetByName(string name);
        IDataResult<PublisherDetailDto> GetById(int id);
    }
}