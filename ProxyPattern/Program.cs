using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballmachine = new UpgradedGumballMachine(150,"New York");
            var monitor = new GumballMonitor(gumballmachine);

            monitor.Report();
        }
    }
}
