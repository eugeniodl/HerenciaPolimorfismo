using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // SalariedEmployee class that extends Employee.
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // four-parameter constuctor
        public SalariedEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal weeklySalary) 
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        // property that gets and sets salaried employee's salary
        public decimal WeeklySalary 
        { 
            get => weeklySalary;
            set
            {
                if(value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(weeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        // calculate earnings; override abstract method Earning in employee
        public override decimal Earnings() => WeeklySalary;

        // return string representation of SalariedEmployee object
        public override string ToString() => $"salaried employee: {base.ToString()}\n" +
            $"weekly salary: {WeeklySalary:C}";
    }
}
