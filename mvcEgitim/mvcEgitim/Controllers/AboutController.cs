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
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutValues = abm.GetList();
            return View(aboutValues);
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            abm.AboutAdd(p);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {

            return PartialView();
        }
    }
}