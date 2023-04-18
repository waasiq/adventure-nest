using AdventureNest.Core.DTOs;
using FluentValidation;

namespace AdventureNest.Service.Validations
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.FirstName).NotNull()
                .WithMessage("User must have a first name.")
                .NotEmpty()
                .WithMessage("User must have a first name.")
                .Length(2,30).
                WithMessage("First name must consist of minimum 2 & maximum 30 characters.");
            
            RuleFor(x => x.LastName).NotNull()
                .WithMessage("User must have a last name.")
                .NotEmpty()
                .WithMessage("User must have a last name.")
                .Length(2, 40).
                WithMessage("First name must consist of minimum 2 & maximum 40 characters.");

            RuleFor(x => x.Email).NotNull()
                .WithMessage("User must have a an email.")
                .NotEmpty()
                .WithMessage("User must have a an email.")
                .EmailAddress().
                WithMessage("Format of email does not valid.");
        }
    }
}
