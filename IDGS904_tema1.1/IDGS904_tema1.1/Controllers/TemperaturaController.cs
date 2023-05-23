using IDGS904_tema1._1.Models;
using IDGS904_tema1._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IDGS904_tema1._1.Controllers
{
    public class TemperaturaController : Controller
    {
        public ActionResult TemperaturaForm()
        {
              return View();
            
        }
        public RedirectToRouteResult TemperaturaProceso(Temperatura T)
        {
            var model = new Temperatura();
            TempData["TemperatraConvertida"] = model.Convertir(T.TempeaturaInicio, T.EscalaAConvertir);
            return RedirectToAction("TemperaturaText");            
        }
        public ActionResult TemperaturaText()
        {

            String tem = "No hay temperatura, regrese al formulario";
            if (TempData.ContainsKey("TemperatraConvertida"))
            {
                tem = TempData["TemperatraConvertida"] as string;
            }
            ViewBag.Fin = tem;
            return View();
        }
    }
}