using Core.ConstValues;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment:1);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Description)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(x => x.Price)
                   .IsRequired()
                   .HasPrecision(6, 2);

            builder.Property(x => x.Stock)
                   .IsRequired();

            builder.Property(x => x.ImgUrl)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.CategoryId)
                   .HasConstraintName("fk_Product_CategoryId");

            builder.HasIndex(x => x.Name)
                   .HasDatabaseName("idx_Product_Name");

            builder.HasIndex(x => new { x.Name, x.Deleted })
                   .HasDatabaseName("idx_Product_Name_Deleted");
        }
    }
}
