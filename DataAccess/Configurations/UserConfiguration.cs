using Core.ConstValues;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment:1);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Password)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Phone)
                   .IsRequired()
                   .HasMaxLength(15);

            builder.Property(x => x.Address)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasIndex(x => x.Name)
                   .HasDatabaseName("idx_User_Name");

        }
    }
}

