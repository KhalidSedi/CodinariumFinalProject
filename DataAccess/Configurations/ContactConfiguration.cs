using Core.ConstValues;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment: 1);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Subject)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Message)
                   .IsRequired()
                   .HasMaxLength(5000);
        }
       
    }
}
