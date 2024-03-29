﻿using BookShopAPI.Application.CQRS.Commands.ViewCommands.AddView;
using FluentValidation;

namespace BookShopAPI.Application.Validators.ViewValidators
{
    public class AddViewValidators : AbstractValidator<AddViewCommandRequest>
    {
        public AddViewValidators()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}