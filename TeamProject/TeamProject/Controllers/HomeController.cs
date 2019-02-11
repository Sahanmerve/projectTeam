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
            var a= db.UserDetails.FirstOrDefault(x=> x.UserDetailID == Id);
            return View(a);
        }
        
        public ActionResult _Conversation(string model)
        {
            Id = (int)Session["id"];
            var a = db.Messages.FirstOrDefault(x => x.UserID == Id);
            MessagesViewModel data = new MessagesViewModel();
            data.Messages = db.Messages.Where(x => x.UserID == Id).ToList();
            return View(data);
        }
    }
}