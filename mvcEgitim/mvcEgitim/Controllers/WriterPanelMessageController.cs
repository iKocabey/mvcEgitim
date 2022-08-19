using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace mvcEgitim.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager mm = new MessageManager(new EfMessageDal());


       
        public ActionResult Inbox()
        {
            string p = (string)Session["WriterEmail"];
            var messageList = mm.GetListInBox(p);
            return View(messageList);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        public ActionResult SendBox()
        {
            string p = (string)Session["WriterEmail"];
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
            string sender = (string)Session["WriterEmail"];
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.SenderMessage = sender;/*Burası sessiondan gelecek veri olacak*/
            mm.MessageAdd(p);
            return RedirectToAction("SendBox");
        }
    }
}