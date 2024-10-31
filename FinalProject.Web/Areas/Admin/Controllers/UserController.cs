using Business.Abstract;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            var data = _userService.GetAll().Data;

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            var result = _userService.Add(user);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var data = _userService.GetById(id).Data;

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            var result = _userService.Update(user);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(int id) 
        {
            var result = _userService.Delete(id);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);
        }
    }
}
