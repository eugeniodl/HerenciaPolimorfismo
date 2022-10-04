using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistemaNomina
{
    public class EmpleadoPorHoras : Empleado
    {
        private decimal sueldo;
        private decimal horas;
        public EmpleadoPorHoras(string nombre, string apellido, string nss,
            decimal sueldoPorHoras, decimal horasTrabajadas)
            : base(nombre, apellido, nss)
        {
            sueldo = sueldoPorHoras;
            horas = horasTrabajadas;
        }

        public decimal Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = (value >= 0) ? value : 0;
            }
        }

        public decimal Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = (value >= 0 && value <= 168) ? value : 0;
            }
        }

        public override decimal Ingresos()
        {
            if (horas <= 40)
                return sueldo * horas;
            else
                return (40 * sueldo) + ((horas - 40) * Sueldo * 1.5M);
        }

        public override string ToString()
        {
            return String.Format(
                "empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
                base.ToString(), "sueldo por horas", Sueldo, "horas trabajadas", horas);
        }
    }
}
