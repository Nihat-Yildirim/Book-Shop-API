using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.CategoryDTOs
{
    public class AddedCategoryDto : IDto
    {
        public AddedCategoryDto()
        {
            ParentCategoryId = 0;
        }

        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
