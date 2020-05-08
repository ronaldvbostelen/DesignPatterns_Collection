using System;
using StatePattern.states;

namespace StatePattern
{
    public class NoQuarterState : GumballMachineState, IState
    {
        public NoQuarterState(GumBallMachine gumBallMachine) : base(gumBallMachine,"No Quarter-state")
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumBallMachine.State = gumBallMachine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You havent inserted a quarter");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("You turned but you there is no quarter");
            return false;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

    }
}