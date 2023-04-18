using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureNest.Repository.Configuring
{
    public class PublicationConfiguration : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(40).HasColumnName("Title");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.IsActive).IsRequired();

            builder.ToTable("Publications");

            builder.HasMany(x => x.Bookings).WithOne(x => x.Publication)
                .HasForeignKey(x => x.PublicationId);
            
            builder.HasOne(x => x.Property).WithOne(x => x.Publication)
                .HasForeignKey<Publication>(x => x.PropertyId);
        }
    }
}
