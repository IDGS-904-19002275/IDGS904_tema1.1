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
    public class TraductorController : Controller
    {
        // GET: Tiendita
        public ActionResult DiccionarioTabla()
        {
            var arch = new TraductorServices();
            Array DiccionarioE = arch.LeerArchivoE();
            ViewBag.ESP = DiccionarioE;
            Array DiccionarioI = arch.LeerArchivoI();
            ViewBag.ING = DiccionarioI;

            return View();
        }
        public ActionResult TraductorGuardar() { return View(); }
        [HttpPost]
        public ActionResult TraductorGuardar(Traductor T)
        {
            var TraductorServicio = new TraductorServices();
            TraductorServicio.GuardarArvchivo(T);
            return View();
        }
        public ActionResult TraductorConsulta(Traductor FORM)
        {
            var arch = new TraductorServices();

            Array DiccionarioE = arch.LeerArchivoE();
            Array DiccionarioI = arch.LeerArchivoI();
            String palabraTraducida = null;

            if (FORM.IDIOMA == 1)
            {
                foreach (string palabra in DiccionarioI)
                {
                    if (palabra == FORM.PALABRA)
                    {
                        int indice = Array.IndexOf(DiccionarioI, palabra);
                        palabraTraducida = (string)DiccionarioE.GetValue(indice);
                    }
                }
            }
            if (FORM.IDIOMA == 2)
            {
                foreach (string palabra in DiccionarioE)
                {
                    if (palabra == FORM.PALABRA)
                    {
                        int indice = Array.IndexOf(DiccionarioE, palabra);
                        palabraTraducida = (string)DiccionarioI.GetValue(indice);
                    }
                }
            }
            if (palabraTraducida == null)
            {
                ViewBag.palabra = "nada, no hay, no existe (en mi diccionario)";
            }
            else
            {
                ViewBag.palabra = palabraTraducida;
            }
            ViewBag.idioma = FORM.IDIOMA;
            ViewBag.palabraOriginal = FORM.PALABRA;
            return View();
        }
    }
}