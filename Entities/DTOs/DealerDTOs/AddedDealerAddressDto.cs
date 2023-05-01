using Entities.DTOs.UserAddressDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.DealerDTOs
{
    public class AddedDealerAddressDto : BaseUserAddressDto
    {
        public int DealerId { get; set; }
    }
}