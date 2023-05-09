using Core.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookPictureDTOs
{
    public class AddedBookPictureDto : IDto
    {
        public int BookId { get; set; }
        public IFormFileCollection BookPictures { get; set; }
    }
}