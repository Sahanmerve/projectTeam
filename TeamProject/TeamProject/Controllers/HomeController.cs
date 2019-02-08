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
        // GET: Home
        public ActionResult Index()
        {             
            TeamProjectContext db = new TeamProjectContext();
            int Id = (int)Session["id"];
            var a= db.UserDetails.FirstOrDefault(x=> x.UserDetailID == Id);

            return View(a);
        }
        public ActionResult _Conversation(string model)
        {
            TeamProjectContext db = new TeamProjectContext();
            MessagesViewModel data = new MessagesViewModel();
            data.Messages = db.Messages.ToList();
            return View(data);
        }
      
    }
}