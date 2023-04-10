using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Repository.Configuring
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.BookingDate).IsRequired();
            builder.Property(x => x.CheckInDate).IsRequired();
            builder.Property(x => x.DepartureDate).IsRequired();
            builder.Property(x => x.PricePerDay).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.BookingStatus).IsRequired().HasMaxLength(30);
            builder.Property(x => x.TotalPrice).IsRequired().HasColumnType("decimal(18,2)");

            builder.ToTable("Bookings");

            builder.HasOne(x => x.Publication).WithMany(x => x.Bookings)
                .HasForeignKey(x => x.PublicationId);

        }
    }
}
