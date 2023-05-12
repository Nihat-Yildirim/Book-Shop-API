using Core.Utilities.Results.Abstract;
using Entities.DTOs.BookPictureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookPictureService
    {
        IResult Add(AddBookPictureDto addedBookPicture);
        IResult Update(UpdateBookPictureDto updatedBookPicture);
        IResult UpdateBookPictureOrderOfAppearance(UpdateBookPictureOrderOfAppearanceDto updateBookPictureOrderOfAppearanceDto);
    }
}