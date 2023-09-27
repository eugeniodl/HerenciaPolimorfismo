using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public interface IPayableSerializer : IDisposable
    {
        public FileStream Fs { get; set; }
        public StreamWriter Sw { get; set; }
        void WritePayableObjects(List<IPayable> payableObjects)
        {
            foreach (var payable in payableObjects)
            {
                Sw.WriteLine($"{payable}");
                Sw.WriteLine(
                    $"payment due: {payable.GetPaymentAmount():C}\n");
            }
        }
        
    }
}
