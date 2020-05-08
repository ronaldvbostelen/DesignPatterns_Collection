using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.states;

namespace StatePattern
{
    class SoldState : GumballMachineState, IState
    {
        public SoldState(GumBallMachine gumBallMachine) : base(gumBallMachine,"Sold-state")
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait we already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Turning twice wont yield more gumballs");
            return false;
        }

        public void Dispense()
        {
            gumBallMachine.ReleaseBall();
            if (gumBallMachine.Gumballs > 0)
            {
                gumBallMachine.State = gumBallMachine.NoQuarterState;
            }
            else
            {
                gumBallMachine.State = gumBallMachine.SoldOutState;
                Console.WriteLine("Oops out of gumballs");
            }

        }

    }
}
