using Core.ConstValues;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable("Abouts");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment: 1);

            builder.Property(x => x.Description)
                   .IsRequired()
                   .HasMaxLength(5000);
        }
    }
}
