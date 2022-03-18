using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.Interface
{
    interface IPeople 
    {
        string Name { get; set; }
        void SellTransport(string x);
        void DriveInSea();
        void PrintProperty();
        void Working();
    }
}
