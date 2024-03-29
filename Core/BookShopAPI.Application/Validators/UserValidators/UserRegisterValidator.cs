﻿using BookShopAPI.Application.CQRS.Commands.UserCommands.CustomerRegister;
using FluentValidation;

namespace BookShopAPI.Application.Validators.UserValidators
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterCommandRequest>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(25);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MinimumLength(15)
                .MaximumLength(100)
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(15);
        }
    }
}