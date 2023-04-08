using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class File : IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }
        public string StorageName { get; set; }
        public DateTime UploadDate { get; set; }
        public bool Status { get; set; }
    }
}