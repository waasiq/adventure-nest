using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Repository.Seeds
{
    public class BookingSeed : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = 1,
                    PublicationId = 1,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-08-11 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-08-17 10:30:00"),
                    CustomerId = 2,
                    PricePerDay = 1000,
                    TotalPrice = 6000
                },
                new Booking
                {
                    Id = 2,
                    PublicationId = 2,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-09-05 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-09-09 10:30:00"),
                    CustomerId = 3,
                    PricePerDay = 4000,
                    TotalPrice = 16000
                },
                new Booking
                {
                    Id = 3,
                    PublicationId = 3,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-10-21 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-10-27 10:30:00"),
                    CustomerId = 1,
                    PricePerDay = 800,
                    TotalPrice = 48000
                },
                new Booking
                {
                    Id = 4,
                    PublicationId = 4,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-12-01 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-08-10 10:30:00"),
                    CustomerId = 3,
                    PricePerDay = 1000,
                    TotalPrice = 10000
                },
                new Booking
                {
                    Id = 5,
                    PublicationId = 5,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-08-11 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-08-17 10:30:00"),
                    CustomerId = 1,
                    PricePerDay = 2500,
                    TotalPrice = 15000
                },
                new Booking
                {
                    Id = 6,
                    PublicationId = 6,
                    CreatedDate = DateTime.Now,
                    BookingDate = DateTime.Now,
                    BookingStatus = "Booked",
                    CheckInDate = DateTime.Parse("2023-05-08 10:30:00"),
                    DepartureDate = DateTime.Parse("2023-05-12 10:30:00"),
                    CustomerId = 2,
                    PricePerDay = 200,
                    TotalPrice = 800
                }
                );
        }
    }
}
