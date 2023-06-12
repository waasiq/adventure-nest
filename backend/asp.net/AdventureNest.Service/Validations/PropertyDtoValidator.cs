using AdventureNest.Core.DTOs;
using FluentValidation;

namespace AdventureNest.Service.Validations
{
    public class PropertyDtoValidator : AbstractValidator<PropertyDto>
    {
        public PropertyDtoValidator()
        {
            RuleFor(x => x.OwnerId).NotEmpty()
                .WithMessage("Property must have an owner ID.")
                .NotNull()
                .WithMessage("Property must have an owner ID.");

            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Property must have a name.")
                .NotNull()
                .WithMessage("Property must have a name.")
                .Length(2, 30)
                .WithMessage("Property name must consist of minimum 2 & maximum 30 characters.");

            RuleFor(x => x.Country).NotEmpty().NotNull()
                .WithMessage("Property must have a country.")
                .Length(2, 40)
                .WithMessage("Country name must consist of minimum 2 & maximum 40 characters.");

            RuleFor(x => x.City).NotEmpty().NotNull()
                .WithMessage("Property must have a city.")
                .Length(2, 30)
                .WithMessage("Property name must consist of minimum 2 & maximum 30 characters.");

            RuleFor(x => x.Address).NotEmpty().NotNull()
                .WithMessage("Property must have an address.")
                .MaximumLength(250)
                .WithMessage("Property address must consist of maximum 250 characters.");

            RuleFor(x => x.PropertyType).NotEmpty().NotNull()
                .WithMessage("Property must have a type.")
                .Length(2, 30)
                .WithMessage("Property type must consist of minimum 2 & maximum 30 characters.");

            RuleFor(x => x.BookingType).NotEmpty().NotNull()
                .WithMessage("Property must have a booking type.")
                .Length(2, 30)
                .WithMessage("Booking type must consist of minimum 2 & maximum 30 characters.");

            RuleFor(x => x.MaxGuestCount).NotEmpty().NotNull()
                .WithMessage("Maxiumum guest count must have a value.")
                .InclusiveBetween(0,int.MaxValue)
                .WithMessage("Maximum guest count must be 0 or greater.");

            RuleFor(x => x.BedroomCount).NotEmpty().NotNull()
                .WithMessage("Bedroom count must have a value.")
                .InclusiveBetween(0, int.MaxValue)
                .WithMessage("Bedroom count must be 0 or greater.");

            RuleFor(x => x.BathroomCount).NotEmpty().NotNull()
                .WithMessage("Bathroom count must have a value.")
                .InclusiveBetween(0, int.MaxValue)
                .WithMessage("Bathroom count must be 0 or greater.");

            RuleFor(x => x.BedCount).NotEmpty().NotNull()
                .WithMessage("Bed count must have a value.")
                .InclusiveBetween(0, int.MaxValue)
                .WithMessage("Bed count must be 0 or greater.");
        }
    }
}
