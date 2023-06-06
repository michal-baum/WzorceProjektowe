using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja dekoratora
    class Decorator : IComponent
    {
        private IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void Operation()
        {
            _component.Operation();
            Console.WriteLine("Dodatkowa operacja na Decorator");
        }
    }

}
