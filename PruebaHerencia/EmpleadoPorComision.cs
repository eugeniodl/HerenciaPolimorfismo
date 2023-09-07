using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHerencia
{
    public class EmpleadoPorComision : object
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal tarifaComision;
        private decimal ventasBrutas;

        public EmpleadoPorComision(string nombre, 
            string apellido, string nss, decimal tarifa,
            decimal venta)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            tarifaComision = tarifa;
            ventasBrutas = venta;
        }

        public string PrimerNombre
        { 
            get
            {
                return primerNombre;
            }
        }
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }
        public string NumeroSeguroSocial
        {
            get 
            { 
                return numeroSeguroSocial; 
            }
        }
        public decimal TarifaComision
        {
            get
            { 
                return tarifaComision; 
            }
            set
            {
                tarifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }
        public decimal VentasBrutas
        {
            get
            {
                return ventasBrutas;
            }
            set 
            { 
                ventasBrutas = (value < 0) ? 0 : value; 
            }
        }
        public virtual decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }

        public override string ToString()
        {
            return String.Format(
                "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "empleado por comisión", PrimerNombre, ApellidoPaterno,
                "número de seguro social", NumeroSeguroSocial,
                "ventas brutas", VentasBrutas, "tarifa de comisión",
                TarifaComision);
        }
    }
}
