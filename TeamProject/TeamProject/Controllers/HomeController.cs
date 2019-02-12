using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;

namespace TeamProject.Controllers
{
    public class HomeController : Controller
    {
        TeamProjectContext db = new TeamProjectContext();
        int Id;
        public ActionResult Index()
        {
            Id = (int)Session["id"];
            var a = db.UserDetails.FirstOrDefault(x => x.UserDetailID == Id);
            return View(a);
        }

        public ActionResult _Conversation(string model)
        {
            Id = (int)Session["id"];
            var a = db.Messages.Where(x => x.UserID == Id).ToList();
            return View(a);
        }

        [HttpGet]
        public ActionResult _Send()
        {
            Id = (int)Session["id"];
            var b = db.UserDetails.Where(x => x.UserDetailID == Id).ToList();
            return View(b);

        }

        [HttpPost]
        public ActionResult _Send(Message Message1)
        {

            if (ModelState.IsValid)
            {
                db.Messages.Add(Message1);
                db.SaveChanges();
                return View();
            }

            return View();
            
        }
    }
}