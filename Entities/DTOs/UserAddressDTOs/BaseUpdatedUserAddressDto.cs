using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.UserAddressDTOs
{
    public abstract class BaseUpdatedUserAddressDto : BaseUserAddressDto
    {
        public int AddressId { get; set; }
    }
}
