using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NuevaVista()
        {
            ViewBag.Message = "Una Vista Nueva";

            return View();
        }
    }
}