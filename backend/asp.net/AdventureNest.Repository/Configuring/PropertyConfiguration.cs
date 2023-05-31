using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureNest.Repository.Configuring
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(40);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(250);
            builder.Property(x => x.PropertyType).IsRequired().HasMaxLength(30);
            builder.Property(x => x.BookingType).IsRequired().HasMaxLength(30);
            builder.Property(x => x.MaxGuestCount).IsRequired();
            builder.Property(x => x.BedroomCount).IsRequired();
            builder.Property(x => x.BathroomCount).IsRequired();
            builder.Property(x => x.BedCount).IsRequired();
            builder.Property(x => x.IsRefrigerator).IsRequired();
            builder.Property(x => x.IsTv).IsRequired();
            builder.Property(x => x.IsCouch).IsRequired();
            builder.Property(x => x.IsBed).IsRequired();
            builder.Property(x => x.IsGasStove).IsRequired();
            builder.Property(x => x.IsBlender).IsRequired();
            builder.Property(x => x.IsCoffeeMaker).IsRequired();
            builder.Property(x => x.IsMicrowave).IsRequired();
            builder.Property(x => x.IsMixingBowl).IsRequired();
            builder.Property(x => x.IsWashingMachine).IsRequired();
            builder.Property(x => x.PhotographsPathList).HasConversion(
                v => string.Join(",", v),
                v => v.Split(",", StringSplitOptions.RemoveEmptyEntries));

            builder.ToTable("Properties");

            builder.HasOne(x => x.User).WithMany(x => x.Properties)
                .HasForeignKey(x => x.OwnerId);

            builder.HasOne(x => x.Publication).WithOne(x => x.Property)
                .HasForeignKey<Publication>(x => x.PropertyId);
        }
    }
}
