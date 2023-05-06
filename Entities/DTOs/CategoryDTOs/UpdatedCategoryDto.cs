using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.CategoryDTOs
{
    public class UpdatedCategoryDto : IDto
    {
        public int CategoryId { get; set; }
        public string NewCategoryName { get; set; }
    }
}
