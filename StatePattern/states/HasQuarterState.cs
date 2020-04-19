using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.states;

namespace StatePattern
{
    class HasQuarterState : GumballMachineState,  IState
    {
        private Random random = new Random();

        public HasQuarterState(GumBallMachine gumBallMachine) : base(gumBallMachine)
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You already inserted a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumBallMachine.State = gumBallMachine.NoQuarterState;
        }

        public bool TurnCrank()
        {
            Console.WriteLine("You turned..");
            if (random.NextDouble() < .1 && gumBallMachine.Gumballs > 1)
            {
                gumBallMachine.State = gumBallMachine.WinnerState;
            }
            else
            {
                gumBallMachine.State = gumBallMachine.SoldState;
            }

            return true;
        }

        public void Dispense()
        {
            Console.WriteLine("Turn the crank first");
        }

    }
}
