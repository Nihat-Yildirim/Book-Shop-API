using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookOfCategoryDTOs
{
    public class AddedBookOfCategoryDto : IDto
    {
        public int BookId { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}