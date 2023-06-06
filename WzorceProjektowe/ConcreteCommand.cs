﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    // Implementacja komendy
    class ConcreteCommand : ICommand
    {
        private Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action();
        }
    }
}
