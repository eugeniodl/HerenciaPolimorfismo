using PayableInterfaceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // Employee abstract base class that implements interface IPayable
    public abstract class Employee : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        // three-parameter constructor
        public Employee(string firstName, string lastName,
            string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        // return string representation of Employee object, using properties
        public override string ToString() => $"{FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}";

        // abstract method overridden by derived classes
        public abstract decimal Earnings(); // no implementation here

        // implenting GetPaymentAmmount here enables the entire Employee
        // class hierarchy to be used in an app that process IPayables
        public decimal GetPaymentAmount() => Earnings();
    }
}
