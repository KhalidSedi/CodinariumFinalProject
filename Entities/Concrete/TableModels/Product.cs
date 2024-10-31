using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Product : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsHomePage { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<ShoppingCard> ShoppingCards { get; set; }
    }
}
