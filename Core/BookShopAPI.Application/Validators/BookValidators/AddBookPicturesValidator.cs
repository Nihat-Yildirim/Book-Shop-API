using BookShopAPI.Application.CQRS.Commands.BookCommands.AddBookPictures;
using FluentValidation;

namespace BookShopAPI.Application.Validators.BookValidators
{
    public class AddBookPicturesValidator : AbstractValidator<AddBookPicturesCommandRequest>
    {
        public AddBookPicturesValidator()
        {
            RuleFor(x => x.BookId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Pictures)
                .NotEmpty()
                .NotNull()
                .Must(x => x.Count > 0)
                    .WithMessage("Lütfen en az 1 adet resim giriniz");

            RuleForEach(x => x.Pictures)
                .Must(CommonRules.CheckPictureExtension)
                    .WithMessage("Lütfen geçerli bir resim uzantılı dosya giriniz");
        }
    }
}