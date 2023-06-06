using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja podstawowego komponentu
    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operacja na ConcreteComponent");
        }
    }
}
