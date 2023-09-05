using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contado : Venta
    {
        public static int n;
        public Contado()
            : base()
        {
            n++;
        }

        public int GetN()
            { return n; }

        // Método de la clase Contado
        public double CalculaDescuento(double subtotal)
        {
            if (subtotal < 1000)
                return 2.0 / 100 * subtotal;
            else if (subtotal >= 1000 && subtotal <= 3000)
                return 5.0 / 100 * subtotal;
            else
                return 12.0 / 100 * subtotal;
        }

        public double CalculaNeto(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
