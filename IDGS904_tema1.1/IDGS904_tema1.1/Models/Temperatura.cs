using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Models
{

    public class Temperatura
    {
        public int TempeaturaInicio { get; set; }

        public int EscalaAConvertir { get; set; }

        public string Convertir(int T, int C)
        {
            double value = 0;
            String fin = "";
            if (C == 1)
            {
                value = (T * 1.8) + 32;
                fin = value.ToString($"0.{new string('#', 2)}") + " F°";
            }
            else
            {
                value = (T - 32) / 1.8;
                fin = value.ToString($"0.{new string('#', 2)}") + " C°";
            }
            return fin;
        }
    }
}