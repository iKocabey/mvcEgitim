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
    public class HeadingController : Controller
    {
        //Burada eklem silme güncelleme gibi CRUD işlemlerini yapıyoruz
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()//Eşittirin yanındaki yapı entity LinQ sorgusudur
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            List<SelectListItem> valuewriter = (from x in wm.GetList()//Eşittirin yanındaki yapı entity LinQ sorgusudur
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName + " " + x.WriterSurname,
                                                    Value = x.WriterId.ToString()
                                                }).ToList();


            ViewBag.vlc2 = valuewriter;
            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()//Eşittirin yanındaki yapı entity LinQ sorgusudur
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();

            ViewBag.vlc = valuecategory;
            var HeadingValue = hm.GetById(id);
            return View(HeadingValue);

        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);
            return RedirectToAction("Index");
        }
    }
}