﻿using Core.Utilities.Helpers.MailHelper;
using Entities.DTOs.DealerDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DealerForRegisterDtoValidator : AbstractValidator<DealerForRegisterDto>
    {
        public DealerForRegisterDtoValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty();
            RuleFor(r => r.FirstName).NotNull();
            RuleFor(r => r.FirstName).MinimumLength(3);
            RuleFor(r => r.FirstName).MaximumLength(75);

            RuleFor(r => r.LastName).NotEmpty();
            RuleFor(r => r.LastName).NotNull();
            RuleFor(r => r.LastName).MinimumLength(3);
            RuleFor(r => r.LastName).MaximumLength(100);

            RuleFor(r => r.Email).NotEmpty();
            RuleFor(r => r.Email).NotNull();
            RuleFor(r => r.Email).Must(MailTool.CheckEmail).WithMessage("Lütfen geçerli bir mail adresi giriniz !");
            RuleFor(r => r.Email).MinimumLength(15);
            RuleFor(r => r.Email).MaximumLength(345);

            RuleFor(r => r.Password).NotEmpty();
            RuleFor(r => r.Password).NotNull();
            RuleFor(r => r.Password).MinimumLength(4);

            RuleFor(r => r.StoreName).NotEmpty();
            RuleFor(r => r.StoreName).NotNull();
            RuleFor(r => r.StoreName).MinimumLength(5);
            RuleFor(r => r.StoreName).MaximumLength(100);

            RuleFor(r => r.StoreDescription).NotEmpty();
            RuleFor(r => r.StoreDescription).NotNull();
            RuleFor(r => r.StoreDescription).MinimumLength(25);
        }
    }
}