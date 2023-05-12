using Core.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookPictureDTOs
{
    public class UpdateBookPictureDto : IDto
    {
        public int BookId { get; set; }
        public int BookPictureId { get; set; }
        public IFormFile NewBookPicture { get; set; }
    }
}