using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ICategoryService categoryService = new CategoryManager();

        CategoryManager _categoryManager = new();
        public IActionResult Index()
        {
            var data = _categoryManager.GetAll().Data;

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var result = _categoryManager.Add(category);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _categoryManager.GetById(id).Data;

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var result = _categoryManager.Update(category);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(category);

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _categoryManager.Delete(id);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);
        }
    }
}
