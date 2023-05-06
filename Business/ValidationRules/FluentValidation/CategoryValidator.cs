using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(r => r.CategoryName).NotNull();
            RuleFor(r => r.CategoryName).NotEmpty();
            RuleFor(r => r.CategoryName).MinimumLength(5);
        }
    }
}