using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // SalariedEmployee class that extends Employee.
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;
        public SalariedEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal weeklySalary) 
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary; // validate salary
        }

        // property that gets and sets salaried employee's salary
        public decimal WeeklySalary 
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(WeeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        // calculate earnings; override absract method Earnings
        // in Employee
        public override decimal Earnings() => WeeklySalary;

        // return string representation of SalariedEmployee object
        public override string ToString()
        {
            return $"salaried employee: {base.ToString()}\n" +
                $"weekly salary: {WeeklySalary:C}";
        }
    }
}
