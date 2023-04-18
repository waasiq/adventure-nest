using AdventureNest.Core.DTOs;
using FluentValidation;

namespace AdventureNest.Service.Validations
{
    public class BookingDtoValidator : AbstractValidator<BookingDto>
    {
        public BookingDtoValidator()
        {
            RuleFor(x => x.PublicationId).NotEmpty()
                .WithMessage("Booking must have a publication ID.")
                .NotNull()
                .WithMessage("Booking must have a publication ID.");

            RuleFor(x => x.CustomerId).NotEmpty()
                .WithMessage("Booking must have a customer ID.")
                .NotNull()
                .WithMessage("Booking must have a publication ID.");

            RuleFor(x => x.BookingDate).NotEmpty()
                .WithMessage("Booking date is must.")
                .NotNull()
                .WithMessage("Booking date is must.");

            RuleFor(x => x.CheckInDate).NotEmpty()
                .WithMessage("Check-in date is must.")
                .NotNull()
                .WithMessage("Check-in date is must.");

            RuleFor(x => x.DepartureDate).NotEmpty()
                .WithMessage("Departure date is must.")
                .NotNull()
                .WithMessage("Booking date is must.");

            RuleFor(x => x.PricePerDay).NotEmpty()
                .WithMessage("Price value is must.")
                .NotNull()
                .WithMessage("Price value is must.")
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage("Price must be 0 or greater.");

            RuleFor(x => x.BookingStatus).NotEmpty()
                .WithMessage("Booking must have a status.")
                .NotNull()
                .WithMessage("Booking must have a status.")
                .MaximumLength(30)
                .WithMessage("Booking name must consist of maximum 30 characters.");

            RuleFor(x => x.TotalPrice).NotEmpty()
                .WithMessage("Total price value is must.")
                .NotNull()
                .WithMessage("Total price value is must.")
                .InclusiveBetween(0, decimal.MaxValue)
                .WithMessage("Total price must be 0 or greater.");
        }
    }
}
