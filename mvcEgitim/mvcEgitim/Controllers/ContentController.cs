using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        
        [AllowAnonymous]
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult  GetAllContent()
        {
            Context c = new Context();
            var values = c;
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }
}
