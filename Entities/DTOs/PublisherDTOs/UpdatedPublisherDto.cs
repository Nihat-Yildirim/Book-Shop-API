using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.PublisherDTOs
{
    public class UpdatedPublisherDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Logo { get; set; }
    }
}
