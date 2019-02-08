using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;

namespace TeamProject.Areas.Panel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Panel/Login
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();

        }
       [HttpPost]
        public JsonResult LoginControl(string name, string password)
        {
            TeamProjectContext db = new TeamProjectContext();
            var sorgu = from U in db.UserLogins where U.UserName == name & U.Password== password select U;
            var User1 = sorgu.FirstOrDefault();
            

            if (User != null)
            {
                Session["id"] = User1.UserID;
                return Json(User1.UserID);
             
            }
            return Json(false);
        }
    }
}