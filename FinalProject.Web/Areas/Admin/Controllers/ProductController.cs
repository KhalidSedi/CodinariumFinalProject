using Business.Abstract;
using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = _productService.GetProductWithCategoryId().Data;

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Categories"] = _categoryService.GetAll().Data;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var result = _productService.Add(product);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError(" ", result.Message);

                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Categories"] = _categoryService.GetAll().Data;

            var data = _productService.GetById(id).Data;

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var result = _productService.Update(product);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _productService.Delete(id);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);
        }
    }
}
