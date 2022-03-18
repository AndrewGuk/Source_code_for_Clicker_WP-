using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.Interface
{
    interface ITransport <T>
    {
        string Name { get; set; }
        int Price { get; set; }
        T Type { get; set; }
        Color Color { get; set; }
        void TransportInfo();
    }
}
