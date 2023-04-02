using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerAvatar : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AvatarFileName { get; set; }
        public string AvatarFilePath { get; set; }
        public string AvatarFileExtension { get; set; }
        public string StorageName { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
