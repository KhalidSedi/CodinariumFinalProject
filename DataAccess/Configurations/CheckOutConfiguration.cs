using Core.ConstValues;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CheckOutConfiguration : IEntityTypeConfiguration<CheckOut>
    {
        public void Configure(EntityTypeBuilder<CheckOut> builder)
        {
            builder.ToTable("CheckOuts");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment:1);

            builder.Property(x => x.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(15);

            builder.Property(x => x.Country)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.State)
                   .HasMaxLength(50);

            builder.Property(x => x.City)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.AddressLine1)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(x => x.AddressLine2)
                   .HasMaxLength(150);

            builder.Property(x => x.ZipCode)
                   .IsRequired(); 
        }
    }
}
