using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BookPicture : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int FileId { get; set; }
        public int OrderOfAppearance { get; set; }
    }
}