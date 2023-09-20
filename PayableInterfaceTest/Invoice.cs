using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class Invoice : IPayable
    {
        public string PartNumber { get;  }
        public string PartDescription { get; }
        private int quantity;
        private decimal pricePerItem;

        public Invoice(string partNumber,
            string partDescription, int quantity,
            decimal pricePerItem)
        {

        }


        public decimal GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
