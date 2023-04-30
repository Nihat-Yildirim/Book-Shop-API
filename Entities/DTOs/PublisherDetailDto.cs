using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PublisherDetailDto : IDto
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string LogoAddress { get; set; }
    }
}
