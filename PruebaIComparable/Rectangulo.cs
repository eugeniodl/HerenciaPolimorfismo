using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIComparable
{
    internal class Rectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
            CalcularArea();
        }

        private void CalcularArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}={2}]", ancho, alto, area);
        }

        public int CompareTo(object? obj)
        {
            Rectangulo rectangulo = obj as Rectangulo;

            if (area > rectangulo.area)
                return 1;

            if (area < rectangulo.area)
                return -1;

            return 0;
        }
    }
}
