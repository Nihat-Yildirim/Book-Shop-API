using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.StoreDTOs
{
    public class StoreDetailDto : IDto
    {
        public int StoreId { get; set; }
        public int DealerId { get; set; }
        public string DealerFirstName { get; set; }
        public string DealerLastName { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string LogoAddress { get; set; }
    }
}
