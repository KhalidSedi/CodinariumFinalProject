using Entities.Concrete.TableModels;

namespace Entities.Concrete.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsHomePage { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ShoppingCard> ShoppingCards { get; set; }
    }
}
