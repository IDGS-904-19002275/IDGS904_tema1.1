using IDGS904_tema1._1.Models;
using IDGS904_tema1._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1._1.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            ViewBag.Nombre = "jjml";
            return View();
        }
        public ActionResult Vista(string n1, string n2 )
        {
            int res=Convert.ToInt32(n1) + Convert.ToInt32(n2); 
            ViewBag.res = res;
            return View();
        }

        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.Operaciones(op.Num1, op.Num2, op.operaciones);
            return View(model);
        }
        
        public ActionResult Muestrapulques()
        {

            var pulques = new ProductoServices();
            var model = pulques.ObtenerProductos();

            return View(model);
        }

        public ActionResult CalcularDistancia(CalcularDistancia CD)
        {
            var model = new CalcularDistancia();
            if (!string.IsNullOrEmpty(CD.X1.ToString()) &&
                !string.IsNullOrEmpty(CD.Y1.ToString()) &&
                !string.IsNullOrEmpty(CD.X2.ToString()) &&
                !string.IsNullOrEmpty(CD.Y2.ToString())
                )
            {
                ViewBag.Resultado = "El resultado es: " + model.Calcular(CD.X1, CD.Y1, CD.X2, CD.Y2);

            }
            else
            {
                ViewBag.Resultado = "No hay resultado, aun";
            }
            return View();
        }

    }
}