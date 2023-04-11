using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserAddress : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AddressTitle { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Neighbourhood { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}