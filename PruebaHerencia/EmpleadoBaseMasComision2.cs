using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHerencia
{
    public class EmpleadoBaseMasComision2 : EmpleadoPorComision
    {
        private decimal salarioBase;
        public EmpleadoBaseMasComision2(string nombre, string apellido, 
            string nss, decimal tarifa, decimal venta, decimal salario) 
            : base(nombre, apellido, nss, tarifa, venta)
        {
            salarioBase = salario;
        }
        public decimal SalarioBase 
        { 
            get 
            { 
                return salarioBase; 
            } 
            set 
            { 
                salarioBase = (value < 0) ? 0 : value;
            } 
        }

        public override decimal Ingresos()
        {
            return salarioBase + base.Ingresos();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\n{2}: {3:C}",
                "salario base +", base.ToString(),
                "salario base", SalarioBase);
        }
    }
}
