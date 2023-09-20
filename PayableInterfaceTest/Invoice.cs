using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // Invoice class implements IPayable
    public class Invoice : IPayable
    {
        public decimal GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
