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
    public class TriangulosController : Controller
    {
        public ActionResult Triangulos() { return View(); }
        [HttpPost]
        public ActionResult Triangulos(Triangulos T)
        {
            var triangulo = new Triangulos();
            double AB = Math.Round(triangulo.Calcular(
                T.X1, T.Y1, T.X2, T.Y2), 2);
            double BC = Math.Round(triangulo.Calcular(
                T.X2, T.Y2, T.X3, T.Y3), 2);
            double CA = Math.Round(triangulo.Calcular(
                T.X3, T.Y3, T.X1, T.Y1), 2);

            // Fórmula de Herón
            double semiperimetro = (AB + BC + CA) / 2;
            double area = Math.Round(
                    Math.Sqrt(
                    semiperimetro *
                    (semiperimetro - AB) *
                    (semiperimetro - BC) *
                    (semiperimetro - CA)), 2);

            double[] L = { AB, BC, CA };
            Array.Sort(L);
            string tipo = "";
            if (L[2] >= (L[1] + L[0]))
            {
                tipo = "No tiene la forma de un triangulo";
            }
            else
            {
                if (AB != BC && BC != CA && CA != AB) { tipo = "Escaleno"; }
                if (AB == BC || BC == CA || CA == AB) { tipo = "Isoseles"; }
                if (AB == BC && BC == CA && CA == AB) { tipo = "Equilatelo"; }

            }

            if (tipo != "Escaleno" && tipo != "Isoseles" && tipo != "Equilatelo")
            {
                ViewBag.Area = "No hay área";
            }
            else
            {
                ViewBag.Area = area;
            }
            ViewBag.Tipo = tipo;
            ViewBag.Lados = L[0] + ", " + L[1] + " y " + L[2];
            return View();
        }

    }
}