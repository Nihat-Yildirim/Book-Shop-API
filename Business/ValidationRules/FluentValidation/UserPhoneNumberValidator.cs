using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserPhoneNumberValidator : AbstractValidator<UserPhoneNumber>
    {
        public UserPhoneNumberValidator()
        {
            RuleFor(r => r.PhoneTitle).NotEmpty();  
            RuleFor(r => r.PhoneTitle).NotNull();

            RuleFor(r => r.PhoneNumber).NotEmpty();
            RuleFor(r => r.PhoneNumber).NotNull();
            RuleFor(r => r.PhoneNumber).Length(11);

            RuleFor(r => r.UserId).NotEmpty();
            RuleFor(r => r.UserId).NotNull();
        }
    }
}
