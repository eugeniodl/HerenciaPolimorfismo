using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfaces
{
    public interface IOperacion
    {
        double Result { get; set; }

        void Calcular(double op1, double op2);

        void Mostrar()
        {
            Console.WriteLine("El resultado es {0}", Result);
        }
    }
}
