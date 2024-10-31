using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class ShoppingCard : BaseEntity, IEntity
    {
        public ShoppingCard()
        {
            Products = new HashSet<Product>();
        }
        public int ProductId { get; set; }
        public byte Quantity { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
