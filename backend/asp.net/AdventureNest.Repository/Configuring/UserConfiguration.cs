using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureNest.Repository.Configuring
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FirsName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Email).IsRequired(); //EMAIL CHECK

            builder.ToTable("Users");
            
            builder.HasMany(x => x.Properties).WithOne(x => x.User)
                .HasForeignKey(x => x.OwnerId);
        }
    }
}
