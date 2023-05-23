using IDGS904_tema1._1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Services
{
    public class TraductorServices
    {
        public void GuardarArvchivo(Traductor form)
        {
            string E = form.ESP + Environment.NewLine;
            string I = form.ING + Environment.NewLine;

            var archivoE = HttpContext.Current.Server.MapPath(
                "~/App_Data/TraductorEspañol.txt");
            var archivoI = HttpContext.Current.Server.MapPath(
                "~/App_Data/TraductorIngles.txt");

            File.AppendAllText(archivoE, E);
            File.AppendAllText(archivoI, I);
        }

        public Array LeerArchivoE()
        {
            Array E = null;
            var archivoE = HttpContext.Current.Server.MapPath(
                "~/App_Data/TraductorEspañol.txt");
            if (File.Exists(archivoE)) 
            {
                E = File.ReadAllLines(archivoE);
            }
            return E;
        }
        public Array LeerArchivoI()
        {
            Array I = null;
            var archivoI = HttpContext.Current.Server.MapPath(
                "~/App_Data/TraductorIngles.txt");
            if (File.Exists(archivoI))
            {
                I = File.ReadAllLines(archivoI);
            }
            return I;
        }
    }
}