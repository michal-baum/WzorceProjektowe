using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja konkretnych produktów
    class SpecialProductB : IProductB
    {
        public void OperationB()
        {
            Console.WriteLine("Operacja B na Special_ProductB");
        }
    }

}
