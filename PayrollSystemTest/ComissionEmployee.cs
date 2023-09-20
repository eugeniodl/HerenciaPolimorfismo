using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // ComissionEmployee class that extends Employee.
    public class ComissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales
        private decimal comissionRate; // comission percentage
        public ComissionEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal grossSales,
            decimal comissionRate) 
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales; // validates gross sales
            ComissionRate = comissionRate; // validates comission rate
        }

        // property that gets and sets comission employee's gross sales
        public decimal GrossSales
        {
            get => grossSales;
            set
            {
                if(value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }
        // property that gets and sets comission employee's comission rate
        public decimal ComissionRate
        {
            get => comissionRate;
            set
            {
                if(value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(ComissionRate)} must be > 0 and < 1");
                }
                comissionRate = value;
            }
        }

        // calculate earnings; override abstract method Earnings in Employee
        public override decimal Earnings() => ComissionRate * GrossSales;

        // return string representation of ComissionEmployee object
        public override string ToString() =>
            $"comission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"comission rate: {ComissionRate:F2}";
    }
}
