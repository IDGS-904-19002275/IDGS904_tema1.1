using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1._1.Models
{
    public class OperasBas
    {

        public int Num1 { get; set; }


        public int Num2 { get; set; }

        public int Res { get; set; }

        public int operaciones { get; set; }


        public void Sumar()
        {
            Res = Num1 + Num2;
        }

        public void Restar()
        {
            Res = Num1 - Num2;
        }
        public void Multiplicar()
        {
            Res = Num1 * Num2;
        }
        public void Dividir()
        {
            Res = Num1 / Num2;
        }


        public void Operaciones(int n1,int n2, int res) {
            Num1 = n1;
            Num2 = n2;
            if(res == 1)
            {
                Sumar();
            }
            if (res == 2)
            {
                Restar();
            }
            if (res == 3)
            {
                Multiplicar();
            }
            if (res == 4)
            {
                Dividir();
            }
        }
    }
}