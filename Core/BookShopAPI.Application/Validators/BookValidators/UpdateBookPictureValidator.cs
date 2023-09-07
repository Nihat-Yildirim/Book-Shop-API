using BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookPicture;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class UpdateBookPictureValidator : AbstractValidator<UpdateBookPictureCommandRequest>
    {
        public UpdateBookPictureValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.BookPictureId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.ShowOrder)
                .NotEmpty()
                .NotNull()
                .Must(x => 5 >= x && x > 0)
                    .WithMessage("Lütfen 5 ile 0 arasında bir değer giriniz");

            RuleFor(x => x.Picture)
                .Must(CheckPictureExtension)
                    .WithMessage("Lütfen geçerli bir resim dosyası gönderiniz");
        }

        public static bool CheckPictureExtension(IFormFile file)
        {
            if (file == null)
                return true;

            List<string> extensions = new()
            {
                ".jpg",
                ".jpeg",
                ".png",
            };

            if (extensions.Contains(Path.GetExtension(file.FileName)))
                return true;

            return false;
        }
    }
}