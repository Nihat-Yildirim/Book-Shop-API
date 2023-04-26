using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DealerValidator : AbstractValidator<Dealer>
    {
        public DealerValidator()
        {
            RuleFor(r => r.UserId).NotEmpty();  
            RuleFor(r => r.UserId).NotNull();

            RuleFor(r => r.StoreId).NotNull();
            RuleFor(r => r.StoreId).NotEmpty(); 
        }
    }
}