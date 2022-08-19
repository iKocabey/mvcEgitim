using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    public class DraftController : Controller
    {
        // GET: Draft
        DraftManager dm = new DraftManager(new EfDraftsDal());
        public ActionResult DraftBox()
        {
            var draftList = dm.GetListDraftBox();
            return View(draftList);
        }
        public ActionResult GetDraftDetails(int id)
        {
            var draftValues = dm.GetById(id);
            return View(draftValues);
        }
        [HttpGet]
        public ActionResult NewDraft()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewDraft(EntityLayer1.Concrete.Draft p)
        {
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.SenderMessage = "admin@gmail.com";
            dm.DraftAdd(p);
            return RedirectToAction("DraftBox");
        }
    }
}