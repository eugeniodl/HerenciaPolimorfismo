using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfaces
{
    public class Multiplicacion : IOperacion
    {
        public double Result { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Calcular(double op1, double op2)
        {
            Result = op1 * op2;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la multiplicación es {0}", Result);
        }
    }
}
