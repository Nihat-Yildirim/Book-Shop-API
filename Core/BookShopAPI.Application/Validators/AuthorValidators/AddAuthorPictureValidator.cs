using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthorPicture;
using FluentValidation;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class AddAuthorPictureValidator : AbstractValidator<AddAuthorPictureCommandRequest>
    {
        public AddAuthorPictureValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.AuthorPicture)
                .NotEmpty()
                .NotNull()
                .Must(x => x.Length > 0)
                    .WithMessage("Lütfen bir dosya giriniz")
                .Must(CommonRules.CheckPictureExtension)
                    .WithMessage("Lütfen geçerli bir resim uzatısı giriniz");
        }
    }
}