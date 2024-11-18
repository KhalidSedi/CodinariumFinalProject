using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
