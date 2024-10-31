using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ProductShoppingCardConfiguration : IEntityTypeConfiguration<ProductShoppingCard>
    {
        public void Configure(EntityTypeBuilder<ProductShoppingCard> builder)
        {
            builder.ToTable("Product_ShoppingCard");

            builder.HasKey(psc => new { psc.ProductId, psc.ShoppingCardId })
                   .HasName("fk_M.Product_M.ShoppingCard");

        }
    }
}
