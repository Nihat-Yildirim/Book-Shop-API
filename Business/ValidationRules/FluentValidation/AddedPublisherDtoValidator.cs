using Entities.DTOs.PublisherDTOs;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AddedPublisherDtoValidator : AbstractValidator<AddedPublisherDto>
    {
        public AddedPublisherDtoValidator()
        {
            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Name).NotNull();
            RuleFor(r => r.Name).MinimumLength(5);

            RuleFor(r => r.Logo).Must(CheckFileLenght).WithMessage("Logo için dosya belirlenmesi gerekmektedir !");
        }

        private bool CheckFileLenght(IFormFile logo)
        {
            if (logo.Length > 0)
                return true;

            return false;
        }
    }
}
