using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Models
{

    public class Temperatura
    {
        public int Tem { get; set; }

        public int Con { get; set; }

        public string Convertir(int T, int C)
        {
            double value = 0;
            String medicion = "";
            if (C == 1)
            {
                value = (T * 1.8) + 32;
                medicion = " F°";
            }
            else
            {
                value = (T - 32) / 1.8;
                medicion = " C°";
            }
            return value.ToString($"0.{new string('#', 2)}") + medicion;

        }
    }
}