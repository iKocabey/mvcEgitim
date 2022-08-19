using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent()
        {
            Context c = new Context();
            string p;
            p = (string)Session["WriterEmail"];
            var writeridinfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterId).FirstOrDefault();
            //ViewBag.d = p;
            var contentvalues = cm.GetListByWriter(writeridinfo);
            return View(contentvalues);
        }
    }
}