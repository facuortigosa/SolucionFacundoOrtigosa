using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.BL
{
    public class Cuadrilatero
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public double GetPerimetro()
        {
            return Lado1 * 2 + Lado2 * 2;
        }

        public double GetArea()
        {
            return Lado1 * Lado2;
        }

        public string GetTipo()
        {
            if (Lado1 == Lado2)
            {
                return "Cuadrado";
            }
            else
            {
                return "Rectangulo";
            }
        }

    }
}
