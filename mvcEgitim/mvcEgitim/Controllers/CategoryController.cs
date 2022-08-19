using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace mvcEgitim.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public object ValidationResult { get; private set; }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryResult()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]//HttpPost olduğunda yani butona tıklandığında  aşağıdaki method çalışacak.
        public ActionResult AddCategory(Category p)
        {
            cm.CategoryAddBL(p);

            return RedirectToAction("GetCategoryResult");//Bu kod bizi GetCategoryResult metoduna gönderdi.
        }
    }
}