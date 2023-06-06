using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja fabryki konkretnych produktów
    class ConcreteFactory : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new SpecialProductA();
        }

        public IProductB CreateProductB()
        {
            return new SpecialProductB();
        }
    }
}
