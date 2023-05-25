using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Models
{
    public class Triangulos
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }


        public double Calcular(double x1, double y1, double x2, double y2)
        {
            double X = x2 - x1;
            double Y = y2 - y1;
            return Math.Sqrt((X * X) + (Y * Y));
        }
    }
}