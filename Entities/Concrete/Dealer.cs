using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Dealer : IEntity
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
    }
}