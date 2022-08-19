using DataAccessLayer.Concrete;
using EntityLayer1.Concreate;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvcEgitim.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminUserInfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName &&
              x.AdminPassword == p.AdminPassword);
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.UserName, false);
                Session["UserName"] = adminUserInfo.UserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            Context c = new Context();
            var writerUserInfo = c.Writers.FirstOrDefault(x => x.WriterEmail == p.WriterEmail &&
              x.WriterPassword == p.WriterPassword);
            if (writerUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerUserInfo.WriterEmail, false);
                Session["WriterEmail"] = writerUserInfo.WriterEmail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }
    }
}