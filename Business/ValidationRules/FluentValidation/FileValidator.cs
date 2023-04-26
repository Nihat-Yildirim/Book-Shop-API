using Entities.Concrete;
using FluentValidation;
using File = Entities.Concrete.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class FileValidator : AbstractValidator<File>
    {
        public FileValidator()
        {
            RuleFor(r => r.StorageName).NotEmpty();
            RuleFor(r => r.StorageName).NotNull();

            RuleFor(r => r.FileName).NotEmpty();
            RuleFor(r => r.FileName).NotNull();
            RuleFor(r => r.FileName).MinimumLength(10);

            RuleFor(r => r.FileExtension).NotEmpty();   
            RuleFor(r => r.FileExtension).NotNull();
            RuleFor(r => r.FileExtension).MinimumLength(2);

            RuleFor(r => r.FilePath).NotEmpty();
            RuleFor(r => r.FilePath).NotNull();
        }
    }
}