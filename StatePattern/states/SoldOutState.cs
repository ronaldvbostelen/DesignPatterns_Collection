using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.states;

namespace StatePattern
{
    class SoldOutState : GumballMachineState, IState
    {
        public SoldOutState(GumBallMachine gumBallMachine) : base(gumBallMachine)
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sold out. You cant insert a quarter");
            EjectQuarter();
        }

        public void EjectQuarter()
        {
            Console.WriteLine("There is no quarter");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Sold out. No Gumball");
            return false;
        }

        public void Dispense()
        {
            Console.WriteLine("Sold out. No Gumball");
        }

    }
}
