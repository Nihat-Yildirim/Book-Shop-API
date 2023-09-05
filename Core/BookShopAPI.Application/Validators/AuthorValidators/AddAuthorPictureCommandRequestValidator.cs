using BookShopAPI.Application.CQRS.Commands.Author.AddAuthorPicture;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators.AuthorValidators
{
    public class AddAuthorPictureCommandRequestValidator : AbstractValidator<AddAuthorPictureCommandRequest>
    {
        public AddAuthorPictureCommandRequestValidator()
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