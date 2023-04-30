using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Autobiography { get; set; }
        public bool Status { get; set; }
    }
}