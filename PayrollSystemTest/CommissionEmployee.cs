﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // CommissionEmployee class that extends Employee.
    public class CommissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales
        private decimal commissionRate; // commission percentage
        public CommissionEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal grossSales,
            decimal commissionRate) 
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales; // validates gross sales
            CommissionRate = commissionRate; // validates commission rate
        }

        // property that gets and sets commission employee's groos sales
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

        // property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get => commissionRate;
            set
            {
                if(value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }
                commissionRate = value;
            }
        }

        // calculate earnings; override abstract method Earnings in Employee
        public override decimal Earnings() => CommissionRate * GrossSales;

        // return string representation of CommissionEmployee object
        public override string ToString() =>
            $"comission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"comission rate: {CommissionRate:F2}";
    }
}
