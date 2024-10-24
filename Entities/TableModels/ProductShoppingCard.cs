using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class ProductShoppingCard : BaseEntity
    {
        //Cross table
        public int ProductId { get; set; }
        public int ShoppingCardId { get; set; }
        public Product Product { get; set; }
        public ShoppingCard ShoppingCard { get; set; }
    }
}
