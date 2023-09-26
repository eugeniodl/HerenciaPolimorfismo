using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public interface IPayableSerializer : IDisposable
    {
        void WritePayableObjects(List<IPayable> payableObjects);
    }
}
