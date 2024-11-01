﻿using Business.Abstract;
using Business.Concrete;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
             _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var data = _categoryService.GetAll().Data;

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateDto dto)
        {
            var result = _categoryService.Add(dto);

            if (!result.IsSuccess)
            {
                ModelState.AddModelError("", result.Message);

                return View();
            }

            return View(dto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _categoryService.GetById(id).Data;

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(CategoryUpdateDto dto)
        {
            var result = _categoryService.Update(dto);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(dto);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);

            if (result.IsSuccess) return RedirectToAction("Index");

            return View(result);
        }
    }
}
