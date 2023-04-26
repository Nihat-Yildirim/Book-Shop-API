using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserAddressValidator : AbstractValidator<UserAddress>
    {
        public UserAddressValidator()
        {
            RuleFor(r => r.UserId).NotEmpty();
            RuleFor(r => r.UserId).NotNull();

            RuleFor(r => r.AddressTitle).NotEmpty();    
            RuleFor(r => r.AddressTitle).NotNull();

            RuleFor(r => r.Description).MaximumLength(250);

            RuleFor(r => r.Province).NotEmpty();
            RuleFor(r => r.Province).NotNull();
            RuleFor(r => r.Province).MinimumLength(4);
            RuleFor(r => r.Province).MaximumLength(14);

            RuleFor(r => r.District).NotEmpty();
            RuleFor(r => r.District).NotNull();
            RuleFor(r => r.District).MinimumLength(3);
            RuleFor(r => r.District).MaximumLength(20);

            RuleFor(r => r.Neighbourhood).NotNull();
            RuleFor(r => r.Neighbourhood).NotEmpty();
            RuleFor(r => r.Neighbourhood).MinimumLength(15);
            RuleFor(r => r.Neighbourhood).MaximumLength(100);

            RuleFor(r => r.Address).NotNull();
            RuleFor(r => r.Address).NotEmpty();
            RuleFor(r => r.Address).MinimumLength(20);
            RuleFor(r => r.Address).MaximumLength(250);
        }
    }
}