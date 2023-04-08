using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public abstract class UserForUpdateDto : IDto
    {
        public int UserId { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
    }
}