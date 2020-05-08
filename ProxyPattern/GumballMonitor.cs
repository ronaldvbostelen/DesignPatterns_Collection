using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class GumballMonitor
    {
        private UpgradedGumballMachine gumballMachine;

        public GumballMonitor(UpgradedGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {gumballMachine.Location}");
            Console.WriteLine($"Current inventory: {gumballMachine.Gumballs} gumballs");
            Console.WriteLine($"Current state: {gumballMachine.GetState()}");
        }
    }
}
