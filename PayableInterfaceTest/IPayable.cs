using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // IPayable interface declaration
    public interface IPayable
    {
        decimal GetPaymentAmount(); // calculate payment; no implementation
    }
}
