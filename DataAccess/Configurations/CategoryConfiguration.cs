using Core.ConstValues;
using Core.Entities.Abstract;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.Property(x => x.Id) 
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment:1);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.IconName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                   .HasDatabaseName("idx_Category_Name");

            builder.HasIndex(x => new { x.Name, x.Deleted })
                   .IsUnique()
                   .HasDatabaseName("idx_Category_Name_Deleted");
        }
    }
}
