using Business.Abstract;
using FinalProject.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        private readonly IProductService _productService;
        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;

            _productService = productService;
        }
        public IActionResult Index()
        {
            var categoryData = _categoryService.GetAll().Data;

            HomeViewModel viewModel = new()
            {
                Categories = categoryData,
            };

            return View(viewModel);
        }
    }
}
