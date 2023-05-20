using IDGS904_tema1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IDGS904_tema1._1.Controllers
{
    public class TienditaController : Controller
    {
        // GET: Tiendita
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Nombre="Pedro",
                Edad=20,
                Activo=true,
                Inscrito = new DateTime(2023,1,1)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Temperatura(Temperatura T)
        {
            var model = new Temperatura();
            if (T.Con != 0)
            {
                string fin = model.Convertir(T.Tem, T.Con);
                return RedirectToAction("TemperaturaFin",
                    new RouteValueDictionary(new { T = fin }));
                
            }
            else
            {
                return View();
            }
        }
        public ActionResult TemperaturaFin(string T)
        {
            ViewBag.Tem = T;
            return View();
        }
    }
}