﻿using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustinsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if(id == null)
            {
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        
        [HttpGet]
        [ValidateAntiForgeryToken]
        /*public IActionResult Upsert(Category category)
         {
             if (ModelState.IsValid)
             {
                 if(category.Id == 0)
                 {
                     _unitOfWork.Category.Add(category);

                 }
                 else
                 {
                     _unitOfWork.Category.Update(category);
                 }
                 _unitOfWork.Save();
                 return RedirectToAction(nameof(Index));
             }
             return View(category);
         } */
        //API Calls Here
        #region
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { date = allObj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successfull" });
        }
        #endregion
    }
}
