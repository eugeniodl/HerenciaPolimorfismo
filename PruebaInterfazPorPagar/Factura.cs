using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfazPorPagar
{
    internal class Factura : IPorPagar
    {
        private string numeroPieza;
        private string descripcionPieza;
        private int cantidad;
        private decimal precioPorArticulo;

        public Factura(string pieza, string descripcion, int cuenta,
            decimal precio)
        {
            numeroPieza = pieza;
            descripcionPieza = descripcion;
            cantidad = cuenta;
            precioPorArticulo = precio;
        }

        public string NumeroPieza
        {
            get 
            { 
                return numeroPieza; 
            }
            set
            {
                numeroPieza = value;
            }
        }

        public string DescripcionPieza
        {
            get 
            { 
                return descripcionPieza; 
            }
            set
            { 
                descripcionPieza = value; 
            }
        }

        public int Cantidad
        {
            get
            { 
                return cantidad; 
            }
            set
            { 
                cantidad = (value < 0) ? 0 : value; 
            }
        }

        public decimal PrecioPorArticulo
        {
            get
            { 
                return precioPorArticulo; 
            }
            set
            {
                precioPorArticulo = (value < 0) ? 0 : value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
                "factura", "número de pieza", numeroPieza, descripcionPieza,
                "cantidad", cantidad, "precio por artículo", precioPorArticulo);
        }

        public decimal ObtenerMontoPago()
        {
            return cantidad * precioPorArticulo;
        }
    }
}
