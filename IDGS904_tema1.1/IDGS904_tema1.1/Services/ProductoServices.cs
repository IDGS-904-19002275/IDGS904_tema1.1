using IDGS904_tema1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Services
{
    public class ProductoServices
    {
        public List<Productos> ObtenerProductos() 
        {
            var producto1 = new Productos()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutos rojos",
                Cantidad = 10,
                Produccion = new DateTime(2022, 11, 5)
            };

            var producto2 = new Productos()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango Piña",
                Cantidad = 35,
                Produccion = new DateTime(2022, 6, 10)
            };

            return new List<Productos> { producto1, producto2 };
        }
    }
}