using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BookOfCategory : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
    }
}