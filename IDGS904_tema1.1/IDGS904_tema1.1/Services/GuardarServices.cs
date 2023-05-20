using IDGS904_tema1._1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Services
{
    public class GuardarServices
    {
        public void GuardaArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre + " , " + apaterno + " , " + amaterno + " , " + edad + " , " +
                email + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }
    }
}