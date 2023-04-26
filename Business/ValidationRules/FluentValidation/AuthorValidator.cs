using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty();
            RuleFor(r => r.FirstName).NotNull();
            RuleFor(r => r.FirstName).MinimumLength(3);
            RuleFor(r => r.FirstName).MaximumLength(75);

            RuleFor(r => r.LastName).NotEmpty();
            RuleFor(r => r.LastName).NotNull();
            RuleFor(r => r.LastName).MinimumLength(3);
            RuleFor(r => r.LastName).MaximumLength(100);

            RuleFor(r => r.Autobiography).NotEmpty();
            RuleFor(r => r.Autobiography).NotEmpty();
            RuleFor(r => r.Autobiography).MinimumLength(50);
        }
    }
}