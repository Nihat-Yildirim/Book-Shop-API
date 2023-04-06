using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Store : IEntity
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}