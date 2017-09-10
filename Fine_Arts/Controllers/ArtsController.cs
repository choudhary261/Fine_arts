using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Fine_Arts.Models;
namespace Fine_Arts.Controllers
{
    public class ArtsController : Controller
    {
        //
        // GET: /Arts/
        public ActionResult Index()

        {

            List<Remarks> list = new List<Remarks>();
            var r1 = new Remarks();
            r1.ID = 1;
            r1.Remrks = "Good";
            r1.ID = 2;
            r1.Remrks = "Good";
            r1.ID = 3;
            r1.Remrks = "Good";
            r1.ID = 4;
            r1.Remrks = "Good";
        

            return View(list);
        }
	}
}