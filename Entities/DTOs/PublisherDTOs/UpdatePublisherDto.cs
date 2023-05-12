using Core.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.PublisherDTOs
{
    public class UpdatePublisherDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Logo { get; set; }
    }
}
