using AdventureNest.Core.DTOs;
using FluentValidation;

namespace AdventureNest.Service.Validations
{
    public class PublicationDtoValidator : AbstractValidator<PublicationDto>
    {
        public PublicationDtoValidator()
        {
            RuleFor(x => x.PropertyID).NotEmpty()
                .WithMessage("Publication must have a property ID.")
                .NotNull()
                .WithMessage("Publication must have a property ID.");

            RuleFor(x => x.Title).NotEmpty()
                .WithMessage("Publication must have a title.")
                .NotNull()
                .WithMessage("Publication must have a title.")
                .MaximumLength(40)
                .WithMessage("Country name must consist of maximum 40 characters.");

            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Publication must have a description.")
                .NotNull()
                .WithMessage("Publication must have a description.")
                .MaximumLength(200)
                .WithMessage("Description must consist of maximum 200 characters.");

            RuleFor(x => x.Price)
                .InclusiveBetween(0,decimal.MaxValue)
                .WithMessage("Price must be 0 or greater.");
        }
    }
}
