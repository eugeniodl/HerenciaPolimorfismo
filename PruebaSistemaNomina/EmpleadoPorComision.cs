using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistemaNomina
{
    public class EmpleadoPorComision : Empleado
    {
        private decimal ventasBrutas;
        private decimal tarifaComision;

        public EmpleadoPorComision(string nombre, string apellido, string nss,
            decimal ventas, decimal tarifa) 
            : base(nombre, apellido, nss)
        {
            ventasBrutas = ventas;
            tarifaComision = tarifa;
        }

        public decimal VentasBrutas
        {
            get 
            { 
                return ventasBrutas; 
            }
            set
            {
                ventasBrutas = (value >= 0) ? value : 0; // validación
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

        public override decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
                "empleado por comisión",base.ToString(), "ventas brutas",ventasBrutas,
                "tarifa de comisión", tarifaComision);
        }
    }
}
