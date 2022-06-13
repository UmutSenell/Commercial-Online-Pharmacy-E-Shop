using BusinessLayer.Concrate;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace E_Shop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DoktorReçeteController : Controller
    {
        // GET: AdminCategory
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.List());
        }

        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Category p)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Insert(p);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Bir Hata Olustu");
            return View();

        }

        
    }
}