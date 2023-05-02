using Core.Entities.Abstract;
using Entities.DTOs.UserAddressDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.DealerDTOs
{
    public class UpdatedDealerAddressDto : BaseUpdatedUserAddressDto
    {
        public int DealerId { get; set; }
    }
}
