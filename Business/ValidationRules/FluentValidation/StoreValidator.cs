using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StoreValidator : AbstractValidator<Store>
    {
        public StoreValidator()
        {
            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Name).NotNull();
            RuleFor(r => r.Name).MinimumLength(5);
            RuleFor(r => r.Name).MaximumLength(100);

            RuleFor(r => r.Description).NotEmpty();
            RuleFor(r => r.Description).NotNull();
            RuleFor(r => r.Description).MinimumLength(25);

            RuleFor(r => r.FileId).NotEmpty();
            RuleFor(r => r.FileId).NotNull();
            
            RuleFor(r => r.Status).NotNull();
            RuleFor(r => r.Status).NotEmpty();
        }
    }
}
