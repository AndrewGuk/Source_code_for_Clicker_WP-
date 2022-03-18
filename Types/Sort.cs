using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class TransportComparer : IComparer<Transport>
    {
        private Func<Transport, Transport, int> compFunc;

        public TransportComparer(Func<Transport, Transport, int> comp)
        {
            compFunc = comp;
        }

        public int Compare(Transport x, Transport y)
        {
            return compFunc(x, y);
        }
    }
}
