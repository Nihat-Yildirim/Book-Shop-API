using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PublisherValidator : AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Name).NotNull();
            RuleFor(r => r.Name).MinimumLength(5);

            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.Id).NotNull();

            RuleFor(r => r.FileId).NotEmpty();
            RuleFor(r => r.FileId).NotNull();
        }
    }
}