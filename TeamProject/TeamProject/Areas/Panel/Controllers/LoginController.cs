using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            if (name == "admin" && password == "123")
            {
                return Json(true);
             
            }
            return Json(false);
        }
    }
}