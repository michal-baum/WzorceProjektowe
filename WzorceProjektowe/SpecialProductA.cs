using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja konkretnych produktów
    class SpecialProductA : IProductA
    {
        public void OperationA()
        {
            Console.WriteLine("Operacja A na Special_ProductA");
        }
    }
}
