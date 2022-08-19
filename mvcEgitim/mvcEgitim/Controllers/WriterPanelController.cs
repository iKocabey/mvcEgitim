using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace mvcEgitim.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        Context c = new Context();
        //int writerIdInfo;
        public ActionResult WriterProfile()
        {
            string p = (string)Session["WriterEmail"];
            ViewBag.d = p;
            var writerIdInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterId).FirstOrDefault();
            ViewBag.a = writerIdInfo;
            var writerNameInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.b = writerNameInfo;
            var writerSurnameInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterSurname).FirstOrDefault();
            ViewBag.c = writerSurnameInfo;
            var writerValue = wm.GetById(writerIdInfo);
            return View(writerValue);
        }
        [AllowAnonymous]
        public ActionResult MyHeading(string p)
        {
          
            p = (string)Session["WriterEmail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterId).FirstOrDefault();
            ViewBag.d = writerIdInfo;
            var ValueHm = hm.GetListByWriter(writerIdInfo);
            return View(ValueHm);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()//Eşittirin yanındaki yapı entity LinQ sorgusudur
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {

            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterId = 0;
            p.HeadingStatus = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
            
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
            return RedirectToAction("MyHeading");
        }
        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);
            return RedirectToAction("MyHeading");
        }
        public ActionResult AllHeading(int p=1)
        {
            var headings=hm.GetList().ToPagedList(p,4); 
            return View(headings);
        }
    }
}