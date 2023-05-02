using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.StorageDTOs
{
    public class ResultFileInfoDto : IDto
    {
        public string FileName { get; set; }
        public string FilePathOrContainerName { get; set; }
        public string FileExtension { get; set; }
    }
}
