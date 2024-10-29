using Core.ConstValues;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ShoppingCardConfiguration : IEntityTypeConfiguration<ShoppingCard>
    {
        public void Configure(EntityTypeBuilder<ShoppingCard> builder)
        {
            builder.ToTable("ShoppingCards");

            builder.Property(x => x.Id)
                   .UseIdentityColumn(seed: SeedConst.Seed_Const_Value, increment: 1);

            builder.Property(x => x.ProductId)
                   .IsRequired();

            builder.Property(x => x.Quantity)
                   .IsRequired(); 
        }
    }
}
