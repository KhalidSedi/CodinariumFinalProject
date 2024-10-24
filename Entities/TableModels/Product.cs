using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Product : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<ShoppingCard> ShoppingCards { get; set; }
    }
}
