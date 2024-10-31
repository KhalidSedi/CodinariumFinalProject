using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        ContactManager _contactManager = new();
        public IActionResult Index()
        {
            var data = _contactManager.GetAll().Data;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            var result = _contactManager.Add(contact);

            if(result.IsSuccess) return RedirectToAction("Index");

            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _contactManager.GetById(id).Data;
            
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            var result = _contactManager.Update(contact);

            if(result.IsSuccess) return RedirectToAction("Index");

            return View(contact);
        }

        [HttpPost]
        public IActionResult Read(int id)
        {
            var result = _contactManager.Find(id);

            if(result != null) return RedirectToAction("Index");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _contactManager.Delete(id);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);    
        }
    }
}
