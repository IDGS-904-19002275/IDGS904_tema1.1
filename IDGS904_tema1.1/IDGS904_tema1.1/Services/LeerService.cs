using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array datos = null;
            var inforMaes = HttpContext.Current.Server.MapPath("~/App_ata/datos.txt");
            if (File.Exists(inforMaes)) 
            {
                datos=File.ReadAllLines(inforMaes);
            }
            return datos;
        }
    }
}