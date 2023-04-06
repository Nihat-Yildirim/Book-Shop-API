using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DealerForRegisterDto : UserForRegisterDto
    {
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
    }
}