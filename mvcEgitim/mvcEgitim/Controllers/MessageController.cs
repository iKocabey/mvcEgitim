using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace mvcEgitim.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox(string p)
        {
            var messageList = mm.GetListInBox(p);
            return View(messageList);
        }
        public ActionResult SendBox(string p)
        {
            var messageList = mm.GetListSendBox(p);
            return View(messageList);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var Values = mm.GetById(id);
            return View(Values);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var Values = mm.GetById(id);
            return View(Values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(EntityLayer1.Concrete.Message p)
        {
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.SenderMessage = "admin@gmail.com";
            mm.MessageAdd(p);
            return RedirectToAction("SendBox");
        }
    }
}