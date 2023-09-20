using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // BasePlusComissionEmployee class that extends ComissionEmployee
    public class BasePlusComissionEmployee : ComissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six-parameter constructor
        public BasePlusComissionEmployee(string firstName, 
            string lastName, string socialSecurityNumber, 
            decimal grossSales, decimal comissionRate) 
            : base(firstName, lastName, socialSecurityNumber, 
                  grossSales, comissionRate)
        {
            BaseSalary = baseSalary; // validates base salary
        }

        // property that gets and sets
        // BasePlusComissionEmployee's base salary
        public decimal BaseSalary
        {
            get => baseSalary;
            set
            {
                if(value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(BaseSalary)} must be >= 0");
                }
                baseSalary = value;
            }
        }

        // calculate earnings
        public override decimal Earnings() => 
            BaseSalary + base.Earnings();

        // return string representation of BasePlusComissionEmployee
        public override string ToString() =>
            $"base salaried {base.ToString()}\nbase salary: {BaseSalary:C}";

    }
}
