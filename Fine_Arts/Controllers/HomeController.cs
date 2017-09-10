using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Fine_Arts.Models;

namespace Fine_Arts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Role rl = new Role();
            rl.ID = 1;
            rl.Roles = "Admin";
             return View(rl);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}