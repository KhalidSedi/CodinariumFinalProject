using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Category : BaseEntity, IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public string IconName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
