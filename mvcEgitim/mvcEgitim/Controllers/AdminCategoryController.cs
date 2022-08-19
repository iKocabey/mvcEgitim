using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        [Authorize(Roles ="B")]//Bu attribute sayesinde  admin girişi olmadımı category kısmına erişim engelleniyor.
        public ActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  Addcategory(Category p)
        {
           
            cm.CategoryAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = cm.GetById(id);
            cm.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValue = cm.GetById(id);
            return View(categoryValue);
        }
        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }

    }
}