using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookPictureDTOs
{
    public class UpdateBookPictureOrderOfAppearanceDto : IDto
    {
        public int PictureId { get; set; }
        public int BookId { get; set; }
        public int OrderOfAppearance { get; set; }
    }
}