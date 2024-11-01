using Entities.Concrete.TableModels;

namespace FinalProject.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
