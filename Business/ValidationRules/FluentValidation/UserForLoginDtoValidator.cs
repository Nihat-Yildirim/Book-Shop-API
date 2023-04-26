using Core.Utilities.Helpers.MailHelper;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForLoginDtoValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginDtoValidator()
        {
            RuleFor(r => r.Email).NotEmpty();
            RuleFor(r => r.Email).NotNull();
            RuleFor(r => r.Email).Must(MailTool.CheckEmail).WithMessage("Lütfen geçerli bir mail adresi giriniz !");
            RuleFor(r => r.Email).MinimumLength(15);
            RuleFor(r => r.Email).MaximumLength(345);

            RuleFor(r => r.Password).NotEmpty();
            RuleFor(r => r.Password).NotNull();
            RuleFor(r => r.Password).MinimumLength(4);
        }
    }
}
