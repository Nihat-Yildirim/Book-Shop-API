using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookPictureDTOs
{
    public class BookPictureDetailDto : IDto
    {
        public int BookPictureId { get; set; }
        public string BookPictureAddress { get; set; }
        public int OrderOfAppearance { get; set; }
    }
}
