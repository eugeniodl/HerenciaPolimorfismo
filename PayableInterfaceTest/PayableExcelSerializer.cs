using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class PayableExcelSerializer : IPayableSerializer
    {
        private FileStream fs;
        private StreamWriter sw;

        public PayableExcelSerializer()
        {
            fs = new FileStream("test.xls", FileMode.Create);
            sw = new StreamWriter(fs);
        }
        public void Dispose()
        {
            if (sw != null)
            {
                sw.Close();
                sw = null;
            }
            if (fs != null)
            {
                fs.Dispose();
                fs = null;
            }
        }

        public void WritePayableObjects(List<IPayable> payableObjects)
        {
            foreach (var payable in payableObjects)
            {
                sw.WriteLine($"{payable}");
                sw.WriteLine(
                    $"payment due: {payable.GetPaymentAmount():C}\n");
            }
        }
    }
}
