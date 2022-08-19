using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        
        public ActionResult Index()
        {
            var contactValue = cm.GetList();

            return View(contactValue);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetById(id);
            return View(contactValues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}