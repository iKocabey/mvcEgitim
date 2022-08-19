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
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();

            return View(WriterValues);
        }
        [HttpGet]//Burası attribute dir.
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]//Burası attribute dir.
        public ActionResult AddWriter(Writer p)
        {
            wm.WriterAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue = wm.GetById(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            wm.WriterUpdate(p);
            return RedirectToAction("Index");
        }
    }
}